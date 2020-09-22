using System;
using System.Collections.Generic;
using System.Text;

namespace Paskaita4_2
{
    class Studentas
    {

        public string vardas { get; set; }
        public string pavarde { get; set; }

        public string pilnasVardas {
            get {
                return $"{vardas} {pavarde}"; 
            }
            set {

                string[] atskirta = value.Split(" ");
                if (atskirta.Length < 2) throw new Exception("Turi buti vardas IR pavarde");
                vardas = value.Split(" ")[0];
                pavarde = value.Split(" ")[1]; 
            } 
        }


        public Studentas(string vardas, string pavarde)
        {
            this.vardas = vardas;
            this.pavarde = pavarde;
        }

        public Studentas(string pilnasVardas)
        {
            this.pilnasVardas = pilnasVardas;
        }

    }
}
