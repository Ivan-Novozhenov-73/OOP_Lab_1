using System;
using Bank_namespace;

namespace Lab_1
{
    class Program
    {
        static void print_info2(ref Bank bank_var)
        {
            Console.Clear();
            Console.WriteLine("Выбран " + bank_var._bankName + "\n");
            Console.WriteLine("Выберите что сделать");
            Console.WriteLine("1) Вывести информацию о банке");
            Console.WriteLine("2) Вывести кол-во клиентов в 16-ричном представлении");
            Console.WriteLine("3) Изменить значение поля");
            Console.Write("Введите число: ");
            string num = Console.ReadLine();

            switch (num)
            {
                case "1":
                    Console.WriteLine("\n" + bank_var);
                    break;

                //case "2":
                //    Console.
                //    break;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа 1. Группа 21ВП2");
            Console.WriteLine("Бригада 6. Антонов, Новоженов \n");

            Bank bank = new Bank();
            Bank sber = new Bank("Сбер");
            Bank tinkoff = new Bank("Тинькофф", 100);
            Bank alpha = new Bank("Альфа-банк", 5000, 4788862.57, 5.3f, 22500, 1990, "Москва");
 
            Console.WriteLine("Выберите банк");
            Console.WriteLine("1) " + bank._bankName);
            Console.WriteLine("2) " + sber._bankName);
            Console.WriteLine("3) " + tinkoff._bankName);
            Console.WriteLine("4) " + alpha._bankName);
            Console.Write("Введите число: ");
            string num = Console.ReadLine();

            switch (num)
            {
                case "1":
                    print_info2(ref bank);
                    break;
                case "2":
                    print_info2(ref sber);
                    break;
                case "3":
                    print_info2(ref tinkoff);
                    break;
                case "4":
                    print_info2(ref alpha);
                    break;
                
            }
        }
    }
}