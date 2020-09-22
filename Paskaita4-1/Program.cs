using System;

namespace Paskaita4_1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Irasykite kiek norite ideti pinigu i banka: ");
            double pinigai;
            int procentai = 2;
            int metai = 2;
            if (!double.TryParse(Console.ReadLine(), out pinigai))
            {
                Console.WriteLine("Blogai ivestas skaicius\n");
                Main();
            }

            //paprastosiosPal(pinigai, metai, procentai);
            paprastosiosPal(pinigai, metai, procentai);
        

        }

        static double paprastosiosPal(double pinigai, int metai, int procentai, Boolean print = true)
        {
            
            double suma;
            suma = pinigai;

            for (int i = 0; i < metai; i++)
            {
                suma += palukanos(pinigai, procentai)-pinigai;
                if (print)
                    Console.WriteLine("Po " + (i + 1) + " metu, jus turite banke: " + String.Format("{0:0.##}", suma) + " litu");
            }

            return suma;
        }


        static double sudetinesPal(double pinigai, int metai, int procentai, Boolean print = true)
        {
            double suma;
            suma = pinigai;

            for (int i = 0; i < metai; i++)
            {
                suma = palukanos(suma, procentai);
                if (print)
                Console.WriteLine("Po " + (i + 1) + " metu, jus turite banke: " + String.Format("{0:0.##}", suma) + " litu");
            }

            return suma;
        }

        private static double palukanos(double pinigai, int procentai)
        {
            double suma;
            suma = pinigai * (1 + procentai / 100.0);
            return suma;
        }
    }
}
