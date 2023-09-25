using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11Problem
{
    internal class DecreasingTriangleStarPattern
    {
    }
    class DecreasingTriangle
    {
        public void TriangleStarPattern()
        {
            for (int i = 8; i >= 1; --i) 
            {
                for(int j = 1;j <= i; j++) 
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
