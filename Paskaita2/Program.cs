using System;

namespace Paskaita2
{
    class Program
    {


        enum SavaitesDienos
        {
            Pirmadienis,
            Antradienis,
            Treciadienis,
            Ketvirtadienis,
            Penktadienis,
            Sestadienis,
            Sekmadienis
        }

        static void Main()
        {

            int diena;
            Console.WriteLine("Iveskite skaiciu nuo 1 iki 7:");
            if (!int.TryParse(Console.ReadLine(), out diena))
            {
                Console.WriteLine("Blogai ivestas skaicius\n");
                Main();
            }
            else
             Console.WriteLine(((SavaitesDienos)diena - 1));
            

            
            
     /*       switch ((SavaitesDienos)diena-1)
            {

                case SavaitesDienos.Pirmadienis:
                    Console.WriteLine("Pirmadienis");
                    break;
                case SavaitesDienos.Antradienis:
                    Console.WriteLine("Antradienis");
                    break;
                case SavaitesDienos.Treciadienis:
                    Console.WriteLine("Treciadienis");
                    break;
                case SavaitesDienos.Ketvirtadienis:
                    Console.WriteLine("Ketvirtadienis");
                    break;
                case SavaitesDienos.Penktadienis:
                    Console.WriteLine("Penktadienis");
                    break;
                case SavaitesDienos.Sestadienis:
                    Console.WriteLine("Sestadienis");
                    break;
                case SavaitesDienos.Sekmadienis:
                    Console.WriteLine("Sekmadienis");
                    break;
                default:
                    Console.WriteLine("Tokios savaites dienos nera :)");
                    break;
            }*/
        }
    }
}
