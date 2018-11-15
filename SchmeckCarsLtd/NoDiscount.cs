using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchmeckCarsLtd
{
    class NoDiscount : IDiscount
    {
        public double ApplyDiscount(double value)
        {
            return value;
        }
    }
}
