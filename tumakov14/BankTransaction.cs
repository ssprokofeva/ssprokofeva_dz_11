using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tumakov14
{
    internal class BankTransaction
    {
        private double sum;
        private DateTime date;
        public double Sum { get; }
        public DateTime Date { get; }
        public BankTransaction(double sum, DateTime date)
        {
            this.date = date;
            Sum = sum;
            Date = date;
        }

        public BankTransaction()
        {

        }
        public BankTransaction(double sum)
        {
            this.sum = sum;
            date = DateTime.Now;
        }
    }
}

