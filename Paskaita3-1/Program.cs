using System;
using System.Collections.Generic;

namespace Paskaita3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Irasykite kiek norite irasyti skaiciu: ");

            int n = int.Parse(Console.ReadLine());

            List<int> skirtingi = new List<int>();

            for (int i = 0; i < n; i++)
            {
                Console.Write("Irasykite skaiciu: ");

                int x = int.Parse(Console.ReadLine());

                bool yra = false;

                foreach (int skc in skirtingi)
                {
                    if (x == skc) yra = true;
                
                }
                
                if (!yra) skirtingi.Add(x);
            }

            foreach (int skc in skirtingi)
            {
                Console.WriteLine(skc);
            }
        }
    }
}
