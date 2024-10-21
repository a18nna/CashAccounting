using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashAccounting
{
    internal class Journal
    {
        private string card;
        private string name;
        public Payment[] payments;
        public static int payment_count;

        public Journal(string card, string name, int max_payments)
        {
            this.card = card;
            this.name = name;
            payments = new Payment[max_payments];
            payment_count = 0;
        }

        public void ShowJournal()
        {
            Console.WriteLine($"Номер карты: {this.card} | Имя: {this.name}");
            for (int i = 0; i < payment_count; i++)
                payments[i].ShowPayment();
        }

        public void AddPayment(Payment payment)
        {
            if (payment_count < payments.Length)
            {
                payments[payment_count] = payment;
                payment_count++;
            }
            else
            {
                Console.WriteLine("Нельзя добавить платеж");
            }
        }
    }
}
