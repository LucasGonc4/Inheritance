using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio.Entities
{
    internal class Outsource_employee : Employee
    {
        public double AdditionalCharge { get; set; }

        public Outsource_employee()
        {
        }

        public Outsource_employee(string name, int hours, double valueperhour, double additionalCharge) : base(name, hours, valueperhour)
        {
            AdditionalCharge = additionalCharge;
        }
        public override double Payment()
        {
            return base.Payment() + AdditionalCharge * 1.1;
        }
    }
}
