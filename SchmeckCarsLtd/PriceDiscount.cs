using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchmeckCarsLtd
{
    class PriceDiscount : IDiscount
    {
        private const double DEFAULT_VALUE = 100000;
        private const double LESS_THAN_DEFAULT = 0.97;
        private const double DEFAULT_AND_MORE = 0.93;

        public double ApplyDiscount(double value)
        {
            return
                value < DEFAULT_VALUE ?
                value * LESS_THAN_DEFAULT :
                value * DEFAULT_AND_MORE;
        }
    }
}
