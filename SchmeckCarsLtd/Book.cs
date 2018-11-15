using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchmeckCarsLtd
{
    class Book
    {
        private List<Transaction> transactions = new List<Transaction>();

        public void AddTransaction(Transaction transaction)
        {
            transactions.Add(transaction);
        }

        public List<Transaction> GetTransactions()
        {
            return new List<Transaction>(transactions);
        }

        internal void Sort(IComparer<Transaction> comparer = null)
        {
            if (comparer == null)
            {
                transactions.Sort();
            }
            else
            {
                transactions.Sort(comparer);
            }
        }
    }
}
