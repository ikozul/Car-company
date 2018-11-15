using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchmeckCarsLtd
{
    class SellTransaction : Transaction
    {
        private IDiscount discount;
        public IDiscount Discount
        {
            set
            {
                discount = value;
            }
        }
        public Buyer Buyer { get; set; }

        public SellTransaction(double price, Car car, DateTime datePaid, Buyer buyer, IDiscount discount) : base(price, car, datePaid)
        {
            Buyer = buyer;
            Discount = discount;
        }

        public override double GetPrice()
        {
            return discount.ApplyDiscount(base.GetPrice());
        }
    }
}
