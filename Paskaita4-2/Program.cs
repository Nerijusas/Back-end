using System;

namespace Paskaita4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Studentas mokinys = new Studentas("Nerijus", "Viluckas");

            mokinys.pilnasVardas = "Antanas antanelis";

            Console.WriteLine(mokinys.vardas);

            
        }
    }
}
