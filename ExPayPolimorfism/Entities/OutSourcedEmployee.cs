using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExPayPolimorfism.Entities
{
    sealed class OutSourcedEmployee : Employee
    {


        internal double AdditionalCharge { get; set; }
        public override double Payment()
        {
            return base.Payment() + (AdditionalCharge * 1.1);
        }
        public OutSourcedEmployee(string name, int hours, double valuePerHour, double payment) : base(name, hours, valuePerHour)
        {
            AdditionalCharge = payment;
        }
    }
}
