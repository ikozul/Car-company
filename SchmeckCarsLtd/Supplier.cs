using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchmeckCarsLtd
{
    class Supplier : Person
    {
        public string Title { get; set; }
        public int IBAN { get; set; }
        public string BankName { get; set; }
        public Supplier(string id, string address, string contact, string title, int iban, string bankName) : base(id, address, contact)
        {
            Title = title;
            IBAN = iban;
            BankName = bankName;
        }

        public override string ToString()
        {
            return string.Format("{0}, Title: {1}, IBAN: {2}, Bank: {3}",
                base.ToString(),
                Title,
                IBAN,
                BankName
            );
        }

    }
}
