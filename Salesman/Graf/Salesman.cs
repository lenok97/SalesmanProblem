using System;

namespace Salesman
{
    class Salesman
    {
        Random random;
        public Tops topsList;
        public Population population;

        /// <summary>
        /// Старт вычисленний (алгоритма)
        /// populationSize - число случайных маршрутов, создаваемых до начала вычислений
        /// maxGenerations - максимальное число скрещиваний
        /// groupSize - число маршрутов, проверяемых в каждом поколении. 2 первых берутся в качестве родительских маршрутов, чьи дочерние маршруты заменят 2 худших маршрута в группе
        /// mutationChance - вероятность мутации дочернего маршрута
        /// seed - затравка генератора случайных чисел
        /// chanceToUseCloseTop - вероятность выбора ближайшей вершины
        /// topsList - список вершин
        /// </summary>
        public Path Begin(int populationSize, int maxGenerations, int groupSize, int mutationChance, int seed, int chanceToUseCloseTop, Tops topsList)
        {
            random = new Random(seed);

            this.topsList = topsList;

            population = new Population();
            population.CreateRandomPopulation(populationSize, topsList, random, chanceToUseCloseTop);

            bool foundNewBestpath = false;
            int generationNumber;
            for (generationNumber = 0; generationNumber < maxGenerations; generationNumber++)
            {
                foundNewBestpath = MakeNewPath(groupSize, mutationChance);
            }
            return population.BestPath;
        }

        /// <summary>
        /// Случайным образом выбирает из популяции группу маршрутов
        /// После сортировки группы по возрастанию длины маршрута два первых рассматриваются как родительские маршруты
        /// Дочерний маршрут заменяет худший маршрут текущей рабочей группы
        /// </summary>
        /// <param name="groupSize">Размер группы</param>
        /// <param name="mutation">вероятность мутации  % дочернего маршрута</param>
        bool MakeNewPath(int groupSize, int mutation)
        {
            int[] parentGroup = new int[groupSize];//рабочая группа 
            int pathCount, i, toppath, childNumber, temppath;

            // Один и тот же маршрут может попасть в рабочую группу неоднократно
            for (pathCount = 0; pathCount < groupSize; pathCount++)
            {
                parentGroup[pathCount] = random.Next(population.Count);
            }

            /// Пузырьковая сортировка по возрастанию длины маршрута
            for (pathCount = 0; pathCount < groupSize - 1; pathCount++)
            {
                toppath = pathCount;
                for (i = toppath + 1; i < groupSize; i++)
                {
                    if (population[parentGroup[i]].Fitness < population[parentGroup[toppath]].Fitness)
                    {
                        toppath = i;
                    }
                }

                if (toppath != pathCount)
                {
                    temppath = parentGroup[pathCount];
                    parentGroup[pathCount] = parentGroup[toppath];
                    parentGroup[toppath] = temppath;
                }
            }

            bool foundNewBestpath = false;

            // скрещивает два лучших пути, потомком заменяет первый худший
            childNumber = parentGroup[groupSize - 1];
            population[childNumber] = Path.Crossover(population[parentGroup[0]], population[parentGroup[1]], topsList, random);
            if (random.Next(100) < mutation)
            {
                population[childNumber].Mutate(random);
            }
            population[childNumber].DetermineFitness(topsList);

            // проверка, если новый маршрут - самый короткий
            if (population[childNumber].Fitness < population.BestPath.Fitness)
            {
                population.BestPath = population[childNumber];
                foundNewBestpath = true;
            }

            // скрещивает два лучших пути, потомком заменяет худший
            childNumber = parentGroup[groupSize - 2];
            population[childNumber] = Path.Crossover(population[parentGroup[1]], population[parentGroup[0]], topsList, random);
            if (random.Next(100) < mutation)
            {
                population[childNumber].Mutate(random);
            }
            population[childNumber].DetermineFitness(topsList);

            // проверка, если новый маршрут - самый короткий
            if (population[childNumber].Fitness < population.BestPath.Fitness)
            {
                population.BestPath = population[childNumber];
                foundNewBestpath = true;
            }

            return foundNewBestpath;
        }
    }
}
