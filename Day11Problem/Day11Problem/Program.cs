using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11Problem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter your Choice: ");
                int a=int.Parse(Console.ReadLine());
                switch (a)
                {
                        case 0:
                        flag = false;
                        break;
                        case 1:
                        DuplicateElement d = new DuplicateElement();
                        d.Element();
                        break;
                        case 2:
                        UniqueElement u=new UniqueElement();
                        u.Unique();
                        break;



                        Console.ReadLine();

                }
            }
        }
    }
}
