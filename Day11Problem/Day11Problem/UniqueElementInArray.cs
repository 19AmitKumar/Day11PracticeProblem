using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11Problem
{
    internal class UniqueElementInArray
    {
    }
    class UniqueElement
    {
        public void Unique()
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
            Console.WriteLine("Unique Elemen is: ");
            for (int i = 0; i < size; i++)
            {
                bool isDuplicate = false;
                for (int j = 0; j < i; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        isDuplicate = true;
                        break;

                    }
                }
                if (!isDuplicate)
                {
                    Console.WriteLine(arr[i]);

                }
            }
        }
    }
}
