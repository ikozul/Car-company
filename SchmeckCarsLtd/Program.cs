using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchmeckCarsLtd
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c1 = new Car(
                "1234A",
                "BMW",
                "Alpina",
                5,
                5,
                80,
                new DateTime(2000, 12, 30),
                Car.Reservoir.Combined
            );
            Console.WriteLine(c1);
            Car c2 = new Car(
                "1A234",
                "Mercedes",
                "500SL",
                5,
                5,
                100,
                new DateTime(2001, 1, 3),
                Car.Reservoir.Gas
            );
            Console.WriteLine(c2 );

            Buyer b = new Buyer(
                "123",
                "Vukovarska 269",
                "Vukovarska 269",
                "Milica",
                "Krmpotic",
                "Croatia",
                123,
                "PU ZG"
            );
            Console.WriteLine(b);

            Supplier s = new Supplier(
                "231", 
                "Selska 5", 
                "Selska 5", 
                "Baotic", 
                12345, 
                "Zaba"
            );
            Console.WriteLine(s);

            SupplyTransaction str1 = new SupplyTransaction
                (80000, c1, DateTime.Now, s, 1000.19, 100000);

            SupplyTransaction str2 = new SupplyTransaction
                (180000, c2, DateTime.Now, s, 2002.19, 200000);

            Book supplierBook = new Book();
            supplierBook.AddTransaction(str1);
            supplierBook.AddTransaction(str2);
            

            SellTransaction st1 = new SellTransaction(
                str1.SellPrice,
                c1,
                DateTime.Now,
                b,
                new NoDiscount()
            );
            SellTransaction st2 = new SellTransaction(
                str2.SellPrice,
                c2,
                DateTime.Now.AddDays(2),
                b,
                new NoDiscount()
            );

            Book buyerBook = new Book();
            buyerBook.AddTransaction(st1);
            buyerBook.AddTransaction(st2);

            st1.Discount = new HolidayDiscount();
            st2.Discount = new HolidayDiscount();

            Console.WriteLine("Supply transactions:");
            buyerBook.GetTransactions().ForEach(Console.WriteLine);

            Console.WriteLine("Default sort:");
            buyerBook.Sort();
            buyerBook.GetTransactions().ForEach(Console.WriteLine);

            Console.WriteLine("Date sort:");
            buyerBook.Sort(new TransactionBookSort());
            buyerBook.GetTransactions().ForEach(Console.WriteLine);

        }
    }
}
