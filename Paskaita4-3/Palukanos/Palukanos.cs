using System;
using System.Collections.Generic;
using System.Text;

namespace Paskaita4_3.Palukanos
{

    
        public abstract class Palukanos
    {
        public Palukanos(double inestaSuma, double procentai)
        {
            InestaSuma = inestaSuma;
            Procentai = procentai;
            DabartineSuma = inestaSuma;
        }

        public double InestaSuma { get; set; }
        public double Procentai { get; set; }
        public double DabartineSuma { get; set; }

       

        public abstract void piniguAugimas(int n, Boolean print = false);
    }
}
