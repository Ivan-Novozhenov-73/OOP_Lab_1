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
            bank.print();
        }
    }
}