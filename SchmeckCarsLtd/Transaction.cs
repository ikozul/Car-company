using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchmeckCarsLtd
{
    class Transaction : IComparable<Transaction>
    {
        private double price;
        public virtual double GetPrice()
        {
            return price;
        }

        public Car Car { get; set; }
        public DateTime DatePaid { get; set; }

        public Transaction(double price, Car car, DateTime datePaid)
        {
            this.price = price;
            Car = car;
            DatePaid = datePaid;
        }

        public override string ToString()
        {
            return string.Format("Car: {0}, Date: {1}, Price: {2}",
                Car,
                DatePaid.ToShortDateString(),
                GetPrice()
            );
        }

        public int CompareTo(Transaction other)
        {
            return -this.GetPrice().CompareTo(other.GetPrice());
        }
    }
}
