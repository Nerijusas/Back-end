using System;
using System.Collections.Generic;

namespace Paskaita3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Irasykite kiek norite irasyti skaiciu: ");

            int n = int.Parse(Console.ReadLine());

            int min=0;
            int max=0;


            for (int i = 0; i < n; i++)
            {

                Console.Write("Irasykite skaiciu: ");

                int x = int.Parse(Console.ReadLine());

                if (i == 0)
                {
                    min = x;
                    max = x;
                }
                else
                {
                    if (min > x) min = x;
                    if (max < x) max = x;
                }
            }

            Console.WriteLine();

            Console.WriteLine("Maziausias skaicius: "+min);
            Console.WriteLine("Didziausias skaicius: " + max);
        }
    }
}
