using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchmeckCarsLtd
{
    class SupplyTransaction : Transaction
    {
        public Supplier Supplier { get; set; }
        public double Taxes { get; set; }
        public double SellPrice { get; set; }

        public SupplyTransaction(double price, Car car, DateTime datePaid, Supplier supplier, double taxes, double sellPrice) : base(price, car, datePaid)
        { 
            Supplier = supplier;
            Taxes = taxes;
            SellPrice = sellPrice;
        }
    }
}
