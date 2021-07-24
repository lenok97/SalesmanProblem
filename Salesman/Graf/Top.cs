using System;
using System.Collections.Generic;

namespace Salesman
{
    /// <summary>
    /// Вершина графа
    /// </summary>
    public class Top
    {
        public Top()
        {
            CloseTops = new List<int>();
            Edges = new List<double>();
        }

        /// <summary>
        /// Ребра из этой вершины
        /// </summary>
       public List<double> Edges { get; set; }

        /// <summary>
        /// Ближайшие вершины
        /// </summary>
       public List<int> CloseTops { get; set; }

       public void FindClosestTops(int numberOfCloseTops)
       {
           double shortestEdge;
           int shortestTop = 0;
           double[] dist = new double[Edges.Count];
           Edges.CopyTo(dist);

           if (numberOfCloseTops > Edges.Count - 1)
           {
               numberOfCloseTops = Edges.Count - 1;
           }

           CloseTops.Clear();

           for (int i = 0; i < numberOfCloseTops; i++)
           {
               shortestEdge = Double.MaxValue;
               for (int cityNum = 0; cityNum < Edges.Count; cityNum++)
               {
                   if (dist[cityNum] < shortestEdge)
                   {
                       shortestEdge = dist[cityNum];
                       shortestTop = cityNum;
                   }
               }
               CloseTops.Add(shortestTop);
               dist[shortestTop] = Double.MaxValue;
           }
       }
    }
}
