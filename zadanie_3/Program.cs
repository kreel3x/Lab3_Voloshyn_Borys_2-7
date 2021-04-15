using System;
using System.Threading;

namespace zadanie_3
{
    class Program
    {
        static void threadRec(object num)
        {
            int n = (int)num;
            if (n <= 0)
                return;
            Thread t = new Thread(threadRec);
            t.Name = "|Thread" + n + "|";
            t.Start(n - 1);
            Console.WriteLine(t.Name);
        }
        private static void Main(string[] args)
        {
            threadRec(10);
            Console.ReadKey();
        }
    }
}
