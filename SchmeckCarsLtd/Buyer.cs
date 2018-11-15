using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchmeckCarsLtd
{
    class Buyer : Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string InsuranceHouse { get; set; }
        public int CardNumber { get; set; }
        public string CardIssuer { get; set; }

        public Buyer(string id, string address, string contact, string name, string suranme, string insuranceHouse, int cardNumber, string cardIssuer) : base(id, address, contact)
        {
            Name = name;
            Surname = suranme;
            InsuranceHouse = insuranceHouse;
            CardNumber = cardNumber;
            CardIssuer = cardIssuer;
        }

        public override string ToString()
        {
            return string.Format("{0}, Name: {1} {2}, Insurance: {3}, Card: {4} ({5})",
                base.ToString(),
                Name,
                Surname,
                InsuranceHouse,
                CardNumber,
                CardIssuer
            );
        }

    }
}
