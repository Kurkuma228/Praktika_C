using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ИзМетодички.classes
{
    internal class BankTransaction
    {
        decimal amount;
        DateTime dateTime;

        public BankTransaction(decimal amount)
        {
            this.amount = amount;
            dateTime = DateTime.Now;
        }
        public decimal GetAmount()
        {
            return amount;
        }
        public DateTime GetDateTime()
        {
            return dateTime;
        }
    }
}
