using System;
using System.Collections.Generic;
using System.Text;

namespace nd.employees
{
    class NewEmployee
    {

        public double Salary { get; set; }
        public double Sicktime { get; set; }
        public double MedicalPlan { get; set; }

        public void taxes()
        {

        }

        public virtual void benefits()
        {
            Console.WriteLine("newEmployee");

        }


    }
}
