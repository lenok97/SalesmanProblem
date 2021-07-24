using System;
using System.Collections.Generic;

namespace Salesman
{
    class Population : List<Path>
    {

        /// <summary>
        /// Лучший найденный на данный момент путь
        /// </summary>
        public Path BestPath { get; set; }
        

        /// <summary>
        /// Формирует популяцию - начальный набор случайных маршрутов
        /// </summary>
        /// <param name="populationSize">число маршрутов</param>
        /// <param name="topList">список вершин</param>
        /// <param name="rand">генератор случайных чисел. Обеспечивает различные результаты при запусках</param>
        /// <param name="chanceToUseCloseTop">вероятность выбора вершины из списка ближайших</param>
        public void CreateRandomPopulation(int populationSize, Tops topList, Random rand, int chanceToUseCloseTop)
        {
            int firstTop, lastTop, nextTop;

            for (int pathCount = 0; pathCount < populationSize; pathCount++)
            {
                Path path = new Path(topList.Count);
                firstTop = rand.Next(topList.Count);
                lastTop = firstTop;
                for (int top = 0; top < topList.Count-1 ; top++)
                {
                    do
                    {
                        // перебирает города, пока не найдет не посещенный
                        if ((rand.Next(100) < chanceToUseCloseTop) && (topList[top].CloseTops.Count > 0))
                        {
                            nextTop = topList[top].CloseTops[rand.Next(topList[top].CloseTops.Count)];

                        }
                        else
                        {
                            nextTop = rand.Next(topList.Count);
                        }
                        // проверка что здесь не были и не находимся здесь сейчас
                        
                    } while ((path[nextTop].Connection2 != -1) || (nextTop == lastTop));
                    
                    path[lastTop].Connection2 = nextTop;
                    path[nextTop].Connection1 = lastTop;
                    lastTop = nextTop;
                }
               
                path[lastTop].Connection2 = firstTop;
                path[firstTop].Connection1 = lastTop;

                path.DetermineFitness(topList);

                Add(path);

                if ((BestPath == null) || (path.Fitness < BestPath.Fitness))
                {
                    BestPath = path;
                }
            }
        }
    }
}
