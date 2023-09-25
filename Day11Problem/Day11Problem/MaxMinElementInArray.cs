using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11Problem
{
    internal class MaxMinElementInArray
    {
        public void MaxMin()
        {
            int size;
            Console.WriteLine("Enter the size of Array: ");
            size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];
            
            Console.WriteLine("Element of Array: ");
            for (int i = 0; i < size; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
                
            }
            int max = arr[0];
            int min = arr[0];
            for (int i = 1;i < size; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                if (arr[i] < min)
                {
                    min = arr[i];
                }

            }
            Console.WriteLine("The maximum Element of an array: " + max);
            Console.WriteLine("The minimum Element of an array: " + min);

        }
    }
}
