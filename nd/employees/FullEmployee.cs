using System;
using System.Collections.Generic;
using System.Text;

namespace nd.employees
{
    class FullEmployee : NewEmployee
    {
        public String DentalPlan{ get; set; }
        public String Vacation { get; set; }
        public String Car { get; set; }


        public override void benefits()
        {
            Console.WriteLine("fullEmployee");
        }
    }
}
