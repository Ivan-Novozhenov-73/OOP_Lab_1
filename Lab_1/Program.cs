using System;
using Bank_namespace;

namespace Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа 1. Группа 21ВП2");
            Console.WriteLine("Бригада 6. Антонов, Новоженов \n");

            Bank bank = new Bank();
            Bank sber = new Bank("Сбер");
            Bank tinkoff = new Bank("Тинькофф", 100);
            Bank alpha = new Bank("Альфа-банк", 5000, 4788862.57, 5.3f, 22500, 1990, "Москва");

            Console.WriteLine(bank);
            Console.WriteLine(sber);
            Console.WriteLine(tinkoff);
            Console.WriteLine(alpha);
        }
    }
}