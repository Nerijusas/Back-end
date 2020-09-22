
using System;
using System.Collections.Generic;
using System.Text;

namespace Paskaita4_3.Palukanos
{
    public class PaprastosiosPalukanos : Palukanos
    {

        public PaprastosiosPalukanos(double inestaSuma, double procentai) : base(inestaSuma,procentai)
        {
            

        }

        public override void piniguAugimas(int n, Boolean print = false)
        {

            for (int i = 0; i < n; i++)
            {
                DabartineSuma += InestaSuma * Procentai / 100;
                if (print)
                    Console.WriteLine("Po " + (i + 1) + " metu, jus turite banke: " + String.Format("{0:0.##}", DabartineSuma) + " litu");
            }
        }
    }
}
