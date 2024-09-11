using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("insert positive number");

            Console.ReadLine();
        }
        static void targil1()
        {
            Console.WriteLine("insert positive number ");
            int numzogi = 0; // מונה לספור כמה מספרים יש זוגיים
            int numezogi = 0;
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            while (num > 0)
            {
                int digit = num % 10;
                if (digit % 2 == 0)
                {
                    numzogi++;
                }
                else numezogi++;
                sum = sum + digit;
                num = num / 10;
            }
            int max = Math.Max(numzogi, numezogi);
            Console.WriteLine($"numbers of zogi is {numzogi}");
            Console.WriteLine($"numbers of ezogi is {numezogi}");
            Console.WriteLine($"number of all the digit togther is {sum}");
            if (numzogi == numezogi)
                Console.WriteLine($"the zogi and ezogi is the same amount {max}");
            else
                Console.WriteLine($"the best is {max}");
            Console.ReadLine();
        }
        static void targil2()
        {
            Console.WriteLine("enter a positive number");
            int num = int.Parse(Console.ReadLine());
            int n = 2;
            int count = 1;
            while (n < num)
            {
                count++;
                n = n * 2;
            }
            Console.WriteLine($"the number that it more then your num by multi 2 is  {n}");
            Console.WriteLine($"the amount of times it took is {count}");
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
        static void targil4()
        {
            Console.WriteLine("insert 2 number a and b ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int count = 0;

            while (a > b)
            {
                a = a - b;
                count++;


            }
            Console.WriteLine($"sharit {a}");
            Console.WriteLine($"count {count}");
        }
        static void targil5()
        {
            Console.WriteLine("insert positive number");
            int num = int.Parse(Console.ReadLine());
            int n = 2;
            while (n <= num)
            {
                if (num % n == 0)
                {
                    Console.WriteLine(n);
                }
                n++;
            }
        }
        static void targil6()
        {
            Console.WriteLine("insert positive number");
            int num = int.Parse(Console.ReadLine());
            int min = 10;
            int max = 0;
            int n = 0;
            while (num > 0)
            {
                n = num % 10;
                if (max < n)
                {
                    max = n;
                }
                if (min > n)
                {
                    min = n;
                }
                num = num / 10;
            }
            Console.WriteLine($"max is {max}");
            Console.WriteLine($"min is {min}");
        }
        static void targil7()
        {
            Console.WriteLine("insert 2 positive number");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int n = 2;
            int max = 0;
            bool tof = true; // means true or false
            while (tof)
            {
                if (num1 % n == 0 && num2 % n == 0)
                {
                    max = n;
                }
                n++;
                if (n > num1 && n > num2)
                {
                    tof = false;
                }
            }
            Console.WriteLine(max);

        }
        static void targil8()
        {
            Console.WriteLine("insert positive number to keep the numbers nagative number to stop");
            int count1 = 0;
            int count2 = 0;
            bool tof = true; // tof stands for true or false
            while (tof)
            {
                int num = int.Parse(Console.ReadLine());
                if (num < 0)
                    tof = false;
                if (num < 10 && num >= 0)
                    count1++;
                if (num > 9) count2++;
            }
            if (count2 > 0)
            {
                Console.WriteLine("not all numbers were one number");
            }
            else
            {
                Console.WriteLine($"every number was one number");
            }
        }
        static void targil9()
        {

        }
        static void targil10()
        {
            Console.WriteLine("insert 50 positive numbers");
            int i = 1;
            int count = 0;
            int zogicount = 0;
            int n = 0;
            int a = 0;
            while (i <= 50)
            {
                int num = int.Parse(Console.ReadLine());
                while (num > 0)
                {
                    n = num % 10;
                    num = num / 10;
                    a = n + num;
                    if (a % 2 == 0) zogicount++;
                    else
                        count++;
                    a = 0;
                    n = 0;

                }
                Console.WriteLine(count);
            }

        }
    }
}
 
