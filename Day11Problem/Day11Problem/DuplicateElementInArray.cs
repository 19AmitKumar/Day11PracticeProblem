using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Day11Problem
{
    internal class DuplicateElementInArray
    {
    }
    class DuplicateElement
    {
        public void Element() {
            int size;
            int count=0;
            Console.WriteLine("Enter the size of Array: ");
            size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];
            Console.WriteLine("Element of Array: ");
            for (int i = 0; i < size; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0;i < size; i++)
            {
                

                for (int j = i+1; j < size; j++)
                {
                    
                    if (arr[i] == arr[j])
                    {
                        count++;
                        break;
                    }

                }
            }
            Console.WriteLine("Total no of duplicate element in array is: " + count);

        }
    } 
}
