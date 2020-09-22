using System;

namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write(fib(100));




            int x = 55;

            Console.WriteLine("for loope: "+fibFor(x));
            Console.WriteLine("Rekursijoje: "+fib((uint)x));
        }

        public static uint fib(uint n)
        {
            if (n <= 1)
                return n;
            return fib(n - 1) + fib(n - 2);


        }
        public static uint fibFor(int x)
        {
            uint a = 0;
            uint b = 1;
            for (int i = 0; i < x - 1; i++)
            {
                uint temp = a + b;
                a = b;
                b = temp;
            }

            return b;
        }
    }
}
