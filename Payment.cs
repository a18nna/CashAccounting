using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashAccounting
{
    internal class Payment 
    {
        private DateTime date;
        private decimal amount;
        private string description;

        public Payment(DateTime date, decimal amount, string description)
        {
            this.date = date;
            this.amount = amount;
            this.description = description;
        }

        public void ShowPayment()
        {
            Console.WriteLine($"Дата: {date} | Сумма: {amount} | Описание: {description}");
        }

    }
}
