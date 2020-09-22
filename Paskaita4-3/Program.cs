using Paskaita4_3.Palukanos;
using System;

namespace Paskaita4_3
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("Irasykite kiek norite ideti pinigu i banka: ");
            double pinigai;
            while (!double.TryParse(Console.ReadLine(), out pinigai))
            {
                Console.WriteLine("Blogai ivestas skaicius\n");
                Console.WriteLine("Irasykite kiek norite ideti pinigu i banka: ");
            }
            Console.WriteLine("Irasykite kokios yra palukanos: ");
            double procentai;
            while (!double.TryParse(Console.ReadLine(), out procentai))
            {
                Console.WriteLine("Blogai ivestas skaicius\n");
                Console.WriteLine("Irasykite kokios yra palukanos: ");
            }
            Console.WriteLine("Irasykite kiek laiko norite laikti pinigus banke: ");
            int metai;
            while (!int.TryParse(Console.ReadLine(), out metai))
            {
                Console.WriteLine("Blogai ivestas skaicius\n");
                Console.WriteLine("Irasykite kiek laiko norite laikti pinigus banke: ");
            }
            Console.WriteLine("Irasykite ar jusu palukanos yra sudetines (true/false): ");
            Boolean sudetines;
            while (!Boolean.TryParse(Console.ReadLine(), out sudetines))
            {
                Console.WriteLine("Blogai ivestas (true/false)\n");
                Console.WriteLine("Irasykite ar jusu palukanos yra sudetines (true/false): ");

            }

            if (sudetines)
            {
                SudetinesPalukanos palukanos = new SudetinesPalukanos(pinigai, procentai);

                palukanos.piniguAugimas(metai, true);
            }
            else
            {
                PaprastosiosPalukanos palukanos = new PaprastosiosPalukanos(pinigai, procentai);

                palukanos.piniguAugimas(metai, true);
            }

        }
    }
}
