using System;
using System.Collections.Generic;
using System.Text;

namespace Paskaita4_3.Palukanos
{
    class SudetinesPalukanos : Palukanos
    {

        public SudetinesPalukanos(double inestaSuma, double procentai) : base(inestaSuma, procentai)
        {

        }


        public override void piniguAugimas(int n, Boolean print = false)
        {

            for (int i = 0; i < n; i++)
            {
                DabartineSuma += DabartineSuma * Procentai / 100.0;
                if (print)
                    Console.WriteLine("Po " + (i + 1) + " metu, jus turite banke: " + String.Format("{0:0.##}", DabartineSuma) + " litu");
            }
        }
    }
}
