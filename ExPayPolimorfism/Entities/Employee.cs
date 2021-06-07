using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExPayPolimorfism.Entities
{
    class Employee
    {
        internal string Name { get; set; }
        internal int Hours { get; set; }
        internal double ValuePerHour { get; set; }
        public Employee(string name, int hours, double valuePerHour)
        {
            Name = name;
            Hours = hours;
            ValuePerHour = valuePerHour;
        }

        public virtual double Payment()
        {
            return Hours * ValuePerHour;
        }
    }
}


