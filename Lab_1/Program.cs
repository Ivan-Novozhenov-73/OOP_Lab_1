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
                case "2":
                    Console.Write("\nКол-во клиентов в 16-ричном представлении = ");
                    Console.WriteLine(Convert.ToString(bank_var.get_numClients(), 16));
                    break;
                case "3":
                    change_field(ref bank_var);
                    break;
            }
        }

        static void change_field(ref Bank bank_var)
        {
            Console.Clear();
            Console.WriteLine("Какое поле изменить?");
            Console.WriteLine("1) Название банка");
            Console.WriteLine("2) Кол-во депозитов");
            Console.WriteLine("3) Сумма депозитов");
            Console.WriteLine("4) Процентная ставка");
            Console.WriteLine("5) Кол-во клиентов");
            Console.WriteLine("6) Год основания");
            Console.WriteLine("7) Расположение");
            Console.Write("Введите число: ");
            string num = Console.ReadLine();

            switch (num)
            {
                case "1":
                    Console.WriteLine("\nТекущее значение: " + bank_var._bankName);
                    Console.Write("Новое значение: ");
                    string bankName = Console.ReadLine();
                    bank_var.set_bankName(bankName);
                    break;
                case "2":
                    Console.WriteLine("\nТекущее значение: " + bank_var.get_countDeposits());
                    Console.Write("Новое значение: ");
                    int countDeposits = Convert.ToInt32(Console.ReadLine());
                    bank_var.set_countDeposits(countDeposits);
                    break;
                case "3":
                    Console.WriteLine("\nТекущее значение: " + bank_var.get_amountDeposits());
                    Console.Write("Новое значение: ");
                    double amountDeposits = Convert.ToDouble(Console.ReadLine());
                    bank_var.set_amountDeposits(amountDeposits);
                    break;
                case "4":
                    Console.WriteLine("\nТекущее значение: " + bank_var.get_interestRate());
                    Console.Write("Новое значение: ");
                    float interestRate = (float)Convert.ToDouble(Console.ReadLine());
                    bank_var.set_interestRate(interestRate);
                    break;
                case "5":
                    Console.WriteLine("\nТекущее значение: " + bank_var.get_numClients());
                    Console.Write("Новое значение: ");
                    int numClients = Convert.ToInt32(Console.ReadLine());
                    bank_var.set_numClients(numClients);
                    break;
                case "6":
                    Console.WriteLine("\nТекущее значение: " + bank_var.get_yearFoundation());
                    Console.Write("Новое значение: ");
                    int yearFoundation = Convert.ToInt32(Console.ReadLine());
                    bank_var.set_yearFoundation(yearFoundation);
                    break;
                case "7":
                    Console.WriteLine("\nТекущее значение: " + bank_var._bankName);
                    Console.Write("Новое значение: ");
                    string location = Console.ReadLine();
                    bank_var.set_location(location);
                    break;
            }

            Console.WriteLine("\nОбновленный объект");
            Console.WriteLine(bank_var);
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