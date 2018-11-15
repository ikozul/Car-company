using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchmeckCarsLtd
{
    static class Extensions
    {
        public static string PrintInFormat(this int value, string format)
        {
            return string.Format("{0} {1}", value, format);
        }
    }
}
