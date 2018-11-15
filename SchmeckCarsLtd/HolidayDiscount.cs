using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchmeckCarsLtd
{
    class HolidayDiscount : IDiscount
    {
        private const double DISCOUNT = 0.95;

        public double ApplyDiscount(double value)
        {
            return value * DISCOUNT;
        }
    }
}
