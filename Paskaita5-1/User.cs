using System;
using System.Collections.Generic;
using System.Text;

namespace Paskaita5_1
{
    public class User
    {
        public string Vardas { get; set; }
        public string Pavarde { get; set; }
        public string Vardas_Pavarde { get { return Vardas + " " + Pavarde; } set { Vardas = value.Split(" ")[0]; Pavarde = value.Split(" ")[1]; } }
        public User(string vardas, string pavarde)
        {
            Vardas = vardas;
            Pavarde = pavarde;
        }

        public User(string vardas_pavarde)
        {
            if (Vardas_Pavarde.Split().Length < 2) throw new Exception("Turi buti Vardas IR Pavarde");

            Vardas_Pavarde = vardas_pavarde;

        }
    }
}
