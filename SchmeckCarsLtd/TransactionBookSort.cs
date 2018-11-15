using System;
using System.Collections.Generic;

namespace SchmeckCarsLtd
{
    internal class TransactionBookSort : IComparer<Transaction>
    {
        public int Compare(Transaction x, Transaction y)
        {
            return x.DatePaid.CompareTo(y.DatePaid);
        }
    }
}