using System;
using System.Collections.Generic;

namespace Salesman
{
    public class Path : List<Link>
    {
        /// <summary>
        /// Конструктор маршрута 
        /// </summary>
        /// <param name="size">Колличество вершин в маршруте</param>
        public Path(int size)
            : base(size)
        {
            resetPath(size);
        }

        public double Fitness { get; set; }

        /// <summary>
        /// Задаёт пустой тур с непосещенными вершинами (все связи = -1)
        /// </summary>
        /// <param name="topsNumber">количество вершин</param>
        private void resetPath(int topsNumber)
        {
            Clear();

            Link link;
            for (int i = 0; i < topsNumber; i++)
            {
                link = new Link();
                link.Connection1 = -1;
                link.Connection2 = -1;
                this.Add(link);
            }
        }

        /// <summary>
        /// Определяет общую протяженность маршрута
        /// </summary>
        public void DetermineFitness(Tops tops)
        {
            Fitness = 0;

            int lasttop = 0;
            int nexttop = this[0].Connection1;

            foreach (Link link in this)
            {
                Fitness += tops[lasttop].Edges[nexttop];

                if (lasttop != this[nexttop].Connection1)
                {
                    lasttop = nexttop;
                    nexttop = this[nexttop].Connection1;
                }
                else
                {
                    lasttop = nexttop;
                    nexttop = this[nexttop].Connection2;
                }
            }
        }

        /// <summary>
        /// Создаёт путь между двумя вершинами. Обновляет список использования
        /// </summary>
        /// <param name="path">незавершенный дочерний путь</param>
        /// <param name="topUsage">сколько раз каждая вершина уже использовалась в маршруте</param>
        private static void AddTop(Path path, int[] topUsage, int top1, int top2)
        {
            if (path[top1].Connection1 == -1)
            {
                path[top1].Connection1 = top2;
            }
            else
            {
                path[top1].Connection2 = top2;
            }

            if (path[top2].Connection1 == -1)
            {
                path[top2].Connection1 = top1;
            }
            else
            {
                path[top2].Connection2 = top1;
            }

            topUsage[top1]++;
            topUsage[top2]++;
        }


        /// <summary>
        /// Находит ребро из заданной вершины в родителе, которое может быть поставлено в потомка
        /// </summary>
        /// <param name="top">вершина откуда ссылаемся</param>
        /// <returns>вершина - на которую ссылается в дочернем маршруте (-1 если ее нет)</returns>
        private static int FindNextTop(Path parent, Path child, Tops topsList, int[] topUsage, int top)
        {
            if (TestConnectionValid(child, topsList, topUsage, top, parent[top].Connection1))
            {
                return parent[top].Connection1;
            }
            else if (TestConnectionValid(child, topsList, topUsage, top, parent[top].Connection2))
            {
                return parent[top].Connection2;
            }

            return -1;
        }

        /// <summary>
        /// Проверяет возможно ли установить ссылку
        /// </summary>
        private static bool TestConnectionValid(Path path, Tops topList, int[] topUsage, int top1, int top2)
        {
            if ((top1 == top2) || (topUsage[top1] == 2) || (topUsage[top2] == 2))
            {
                return false;
            }

            if ((topUsage[top1] == 0) || (topUsage[top2] == 0))
            {
                return true;
            }

            for (int direction = 0; direction < 2; direction++)
            {
                int lastTop = top1;
                int currentTop;
                if (direction == 0)
                {
                    currentTop = path[top1].Connection1;  
                }
                else
                {
                    currentTop = path[top1].Connection2; 
                }
                int pathLength = 0;
                while ((currentTop != -1) && (currentTop != top2) && (pathLength < topList.Count - 2))
                {
                    pathLength++;
                    if (lastTop != path[currentTop].Connection1)
                    {
                        lastTop = currentTop;
                        currentTop = path[currentTop].Connection1;
                    }
                    else
                    {
                        lastTop = currentTop;
                        currentTop = path[currentTop].Connection2;
                    }
                }

                //если вершины соединены и путь образует цикл
                if (pathLength >= topList.Count - 2)
                {
                    return true;
                }

                // если вершины соединены, но путь проходит не через все вершины
                if (currentTop == top2)
                {
                    return false;
                }
            }

            // города не связаны ни в одном из направлений
            return true;
        }

        /// <summary>
        /// Оператор кроссовера между двумя родителями чтобы получить потомка
        /// Вызывается дважды, если нужно два потомка, при этом параметры родителей меняются
        /// <returns>Маршрут потомка</returns>
        public static Path Crossover(Path parent1, Path parent2, Tops topList, Random rand)
        {
            Path child = new Path(topList.Count);      
            int[] topUsage = new int[topList.Count];  
            int top;                                  
            int nextTop;                            

            for (top = 0; top < topList.Count; top++)
            {
                topUsage[top] = 0;
            }

            // поместить все общие ссылки родителей ребенку
            for (top = 0; top < topList.Count; top++)
            {
                if (topUsage[top] < 2)
                {
                    if (parent1[top].Connection1 == parent2[top].Connection1)
                    {
                        nextTop = parent1[top].Connection1;
                        if (TestConnectionValid(child, topList, topUsage, top, nextTop))
                        {
                            AddTop(child, topUsage, top, nextTop);
                        }
                    }
                    if (parent1[top].Connection2 == parent2[top].Connection2)
                    {
                        nextTop = parent1[top].Connection2;
                        if (TestConnectionValid(child, topList, topUsage, top, nextTop))
                        {
                            AddTop(child, topUsage, top, nextTop);

                        }
                    }
                    if (parent1[top].Connection1 == parent2[top].Connection2)
                    {
                        nextTop = parent1[top].Connection1;
                        if (TestConnectionValid(child, topList, topUsage, top, nextTop))
                        {
                            AddTop(child, topUsage, top, nextTop);
                        }
                    }
                    if (parent1[top].Connection2 == parent2[top].Connection1)
                    {
                        nextTop = parent1[top].Connection2;
                        if (TestConnectionValid(child, topList, topUsage, top, nextTop))
                        {
                            AddTop(child, topUsage, top, nextTop);
                        }
                    }
                }
            }

            // если далее нет общих ссылок -
            // чередуем ссылки от parent 1 или parent 2

            for (top = 0; top < topList.Count; top++)
            {
                if (topUsage[top] < 2)
                {
                    if (top % 2 == 1)  // приоритет parent 1 в нечетных городах
                    {
                        nextTop = FindNextTop(parent1, child, topList, topUsage, top);
                        if (nextTop == -1) // если не возможно переходим к parent 2
                        {
                            nextTop = FindNextTop(parent2, child, topList, topUsage, top); ;
                        }
                    }
                    else //приоритет parent 2 в четных городах
                    {
                        nextTop = FindNextTop(parent2, child, topList, topUsage, top);
                        if (nextTop == -1)
                        {
                            nextTop = FindNextTop(parent1, child, topList, topUsage, top);
                        }
                    }

                    if (nextTop != -1)
                    {
                        AddTop(child, topUsage, top, nextTop);

                        // 
                        if (topUsage[top] == 1)
                        {
                            if (top % 2 != 1)  //  parent 1 в четных городах
                            {
                                nextTop = FindNextTop(parent1, child, topList, topUsage, top);
                                if (nextTop == -1) 
                                {
                                    nextTop = FindNextTop(parent2, child, topList, topUsage, top);
                                }
                            }
                            else // parent 2 иначе
                            {
                                nextTop = FindNextTop(parent2, child, topList, topUsage, top);
                                if (nextTop == -1)
                                {
                                    nextTop = FindNextTop(parent1, child, topList, topUsage, top);
                                }
                            }

                            if (nextTop != -1)
                            {
                                AddTop(child, topUsage, top, nextTop);
                            }
                        }
                    }
                }
            }

            // Оставшиеся ссылки должны быть случайными
            // иначе будет несколько несвязных путей 
            for (top = 0; top < topList.Count; top++)
            {
                while (topUsage[top] < 2)
                {
                    do
                    {
                        nextTop = rand.Next(topList.Count);  // поиск другой вершины для связи
                    } while (!TestConnectionValid(child, topList, topUsage, top, nextTop));

                    AddTop(child, topUsage, top, nextTop);
                }
            }

            return child;
        }

        /// <summary>
        /// Случаным образом меняем местами 2 города маршрута или 2 куска маршрута
        /// </summary>
        public void Mutate(Random rand)
        {
            int topNumber = rand.Next(this.Count);
            Link link = this[topNumber];
            int tmpTopNumber;

            // Находит две вершины связанные с этой и соединяет их напрямую
            if (this[link.Connection1].Connection1 == topNumber)   
            {
                if (this[link.Connection2].Connection1 == topNumber)
                {
                    tmpTopNumber = link.Connection2;
                    this[link.Connection2].Connection1 = link.Connection1;
                    this[link.Connection1].Connection1 = tmpTopNumber;
                }
                else                                                
                {
                    tmpTopNumber = link.Connection2;
                    this[link.Connection2].Connection2 = link.Connection1;
                    this[link.Connection1].Connection1 = tmpTopNumber;
                }
            }
            else                                                    
            {
                if (this[link.Connection2].Connection1 == topNumber)
                {
                    tmpTopNumber = link.Connection2;
                    this[link.Connection2].Connection1 = link.Connection1;
                    this[link.Connection1].Connection2 = tmpTopNumber;
                }
                else                                            
                {
                    tmpTopNumber = link.Connection2;
                    this[link.Connection2].Connection2 = link.Connection1;
                    this[link.Connection1].Connection2 = tmpTopNumber;
                }

            }

            int replaceTopNumber = -1;
            do
            {
                replaceTopNumber = rand.Next(this.Count);
            }
            while (replaceTopNumber == topNumber);
            Link replaceLink = this[replaceTopNumber];

            // помещает вершину обратно в путь в случайное место
            tmpTopNumber = replaceLink.Connection2;
            link.Connection2 = replaceLink.Connection2;
            link.Connection1 = replaceTopNumber;
            replaceLink.Connection2 = topNumber;

            if (this[tmpTopNumber].Connection1 == replaceTopNumber)
            {
                this[tmpTopNumber].Connection1 = topNumber;
            }
            else
            {
                this[tmpTopNumber].Connection2 = topNumber;
            }
        }


    }
}
