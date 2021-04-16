using System;
using System.Linq;
using System.Threading;

namespace zadanie_4
{
    class Program
    {
        static Random random = new Random();
        static void Main(string[] args)
        {
            while (true)
            {
                Lancyjok();
            }
        }
        static void Lancyjok()
        {

            int LancyjokLength = random.Next(25);
            for (int i = 0; i < LancyjokLength; i++)
            {
                if (i == 0)
                {
                    print1();
                    Thread.Sleep(500);
                    if (LancyjokLength == 1)
                    {
                        Console.Clear();
                        break;
                    }
                    continue;
                }
                if (i == 1)
                {
                    Console.Clear();
                    print2();
                    Thread.Sleep(500);
                    if (LancyjokLength == 2)
                    {
                        Console.Clear();
                        break;
                    }
                    continue;
                }
                printn(i);
                Thread.Sleep(500);
                if (i == LancyjokLength - 1)
                {
                    Console.Clear();
                }
            }

        }
        static void print1()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(String.Concat(Enumerable.Repeat(" ", 2)) + random.Next(9));
        }
        static void print2()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(String.Concat(Enumerable.Repeat(" ", 2)) + random.Next(9));
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(String.Concat(Enumerable.Repeat(" ", 2)) + random.Next(9));


        }
        static void printn(int n)
        {
            Console.Clear();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();
            }

            for (int i = 1; i < n; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine(String.Concat(Enumerable.Repeat(" ", 2)) + random.Next(9));
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(String.Concat(Enumerable.Repeat(" ", 2)) + random.Next(9));
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(String.Concat(Enumerable.Repeat(" ", 2)) + random.Next(9));
        }
    }
}
