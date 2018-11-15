using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchmeckCarsLtd
{
    abstract class Person
    {
        public Person(string id, string address, string contact)
        {
            ID = id;
            Address = address;
            Contact = contact;
        }

        public string ID { get; set; }
        public string Address { get; set; }
        public string Contact { get; set; }

        public override string ToString()
        {
            return string.Format("ID: {0}, Address: {1}, Contact: {2}",
                ID,
                Address,
                Contact
            );
        }
    }
}
