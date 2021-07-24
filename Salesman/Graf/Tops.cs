using System.Collections.Generic;

namespace Salesman
{
    public class Tops : List<Top>
    {

        public void CalculateTopsEdges(int numberOfCloseTops)
        {

            foreach (Top top in this)
            {
                top.FindClosestTops(numberOfCloseTops);
            }
        }
    }
}
