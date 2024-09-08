using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("insert 2 number a and b ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int count = 0;
            
            while (a>b)
            {
                a = a - b;
                count++;
               
                
            }
                Console.WriteLine($"sharit {a}");
            Console.WriteLine($"count {count}");

            Console.ReadLine();
        }
        static void targil3()
        {
            Console.WriteLine("insert positive number");
            int num = int.Parse(Console.ReadLine());
            int n = 2;
            while (num >= n)
            {
                n = n * 2;
                if (n < num)
                {
                    Console.WriteLine(n);
                }
            }
        }
    }
}
