using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11Problem
{
    internal class FrequencyOfArray
    {
        public void Frequency()
        {
            int size,count;
            Console.WriteLine("Enter the size of Array: ");
            size = Convert.ToInt32(Console.ReadLine());
            int [] arr = new int[size];
            int [] frequency= new int[size];
            Console.WriteLine("Element of Array: ");
            for (int i = 0; i < size; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
                frequency[i] = -1;
            }
            
            for (int i = 0; i < size; i++)
            {
                count = 1;
                
                for (int j = 0; j < i; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                        frequency[j]=0;


                    }
                }
                if (frequency[i] !=0)
                {
                    frequency[i]=count;

                }
            }
            Console.WriteLine("Frequency of an Array is: ");
            for (int i = 0;i < size; i++)
            {
                if (frequency[i] != 0)
                {
                    Console.WriteLine(arr[i]+" occur " + frequency[i]+" times ");
                }
            }
        }
    }
    
}
