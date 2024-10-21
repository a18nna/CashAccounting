using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashAccounting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Journal journal = new Journal("2345 7584 8734 7564", "Alena", 1);
            Journal journal1 = new Journal("2345 1324 8474 8474", "Masha", 2);
            Journal journa2 = new Journal("2345 3645 6273 6473", "Lena", 4);
            journal.AddPayment(new Payment(DateTime.Now, 100, "Оплата за услуги"));
            journal.AddPayment(new Payment(DateTime.Now.AddDays(-1), 200, "Покупка товаров"));
            journal.AddPayment(new Payment(DateTime.Now.AddDays(-2), 50, "Оплата за обед"));

            Console.Write("Выберите дествие: \n\t 1. Показать журнал \n\t 2. Показать платежи \n\t 3. Добавить платеж");
            switch (Console.ReadLine())
            {
                case "1":
                    journal1.ShowJournal();
                    break;
                case "2":
             //       payment.ShowPayment();
                    break;
                case "3":
                    DateTime date = DateTime.Now;
                    Console.WriteLine("Введите сумму платежа = ");
                    decimal amount = decimal.Parse(Console.ReadLine());
                    Console.WriteLine("Описание платежа: ");
                    string description = Console.ReadLine();
                    Payment payment = new Payment(date, amount, description);
                    journal.AddPayment(payment);
                    break;
            }

            Console.ReadKey();
        }
    }
}
