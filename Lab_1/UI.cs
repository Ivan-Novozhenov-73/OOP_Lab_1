using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    internal class UI
    {
        public static void print_info()
        {
            Console.WriteLine("Лабораторная работа 1. Группа 21ВП2");
            Console.WriteLine("Бригада 6. Антонов, Новоженов \n");
        }

        public static void print_info2(ref Bank bank_var)
        {
            Console.Clear();
            Console.WriteLine("Выбран " + bank_var._bankName + "\n");
            Console.WriteLine("Выберите что сделать");
            Console.WriteLine("1) Вывести информацию о банке");
            Console.WriteLine("2) Вывести кол-во клиентов в 16-ричном представлении");
            Console.WriteLine("3) Изменить значение поля");

            bool flag = true;
            while (flag)
            {
                Console.Write("Введите число: ");
                string num = Console.ReadLine();

                switch (num)
                {
                    case "1":
                        flag = false;
                        Console.WriteLine("\n" + bank_var);
                        break;
                    case "2":
                        flag = false;
                        Console.Write("\nКол-во клиентов в 16-ричном представлении = ");
                        Console.WriteLine(Convert.ToString(bank_var.get_numClients(), 16));
                        break;
                    case "3":
                        flag = false;
                        UI.change_field(ref bank_var);
                        break;
                    default:
                        Console.WriteLine("Неверное значение!\n");
                        continue;
                }
            }
        }

        public static void change_field(ref Bank bank_var)
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

            bool flag = true, flag2 = true;
            int num = 0;
            while (flag)
            {
                try
                {
                    if (flag2)
                    {
                        Console.Write("Введите число: ");
                        num = Convert.ToInt32(Console.ReadLine());
                    }   
                    switch (num)
                    {
                        case 1:
                            flag2 = false;
                            Console.WriteLine("\nТекущее значение: " + bank_var._bankName);
                            Console.Write("Новое значение: ");
                            string bankName = Console.ReadLine();
                            bank_var.set_bankName(bankName);
                            flag = false;
                            break;
                        case 2:
                            flag2 = false;
                            Console.WriteLine("\nТекущее значение: " + bank_var.get_countDeposits());
                            Console.Write("Новое значение: ");
                            int countDeposits = Convert.ToInt32(Console.ReadLine());
                            bank_var.set_countDeposits(countDeposits);
                            flag = false;
                            break;
                        case 3:
                            flag2 = false;
                            Console.WriteLine("\nТекущее значение: " + bank_var.get_amountDeposits());
                            Console.Write("Новое значение: ");
                            double amountDeposits = Convert.ToDouble(Console.ReadLine());
                            bank_var.set_amountDeposits(amountDeposits);
                            flag = false;
                            break;
                        case 4:
                            flag2 = false;
                            Console.WriteLine("\nТекущее значение: " + bank_var.get_interestRate());
                            Console.Write("Новое значение: ");
                            float interestRate = (float)Convert.ToDouble(Console.ReadLine());
                            bank_var.set_interestRate(interestRate);
                            flag = false;
                            break;
                        case 5:
                            flag2 = false;
                            Console.WriteLine("\nТекущее значение: " + bank_var.get_numClients());
                            Console.Write("Новое значение: ");
                            int numClients = Convert.ToInt32(Console.ReadLine());
                            bank_var.set_numClients(numClients);
                            flag = false;
                            break;
                        case 6:
                            flag2 = false;
                            Console.WriteLine("\nТекущее значение: " + bank_var.get_yearFoundation());
                            Console.Write("Новое значение: ");
                            int yearFoundation = Convert.ToInt32(Console.ReadLine());
                            bank_var.set_yearFoundation(yearFoundation);
                            flag = false;
                            break;
                        case 7:
                            flag2 = false;
                            Console.WriteLine("\nТекущее значение: " + bank_var.get_location());
                            Console.Write("Новое значение: ");
                            string location = Console.ReadLine();
                            bank_var.set_location(location);
                            flag = false;
                            break;
                        default:
                            Console.WriteLine("Неверное значение!\n");
                            continue;
                    }

                    Console.WriteLine("\nОбновленный объект");
                    Console.WriteLine(bank_var);
                }
                catch
                {
                    Console.WriteLine("Недопустимое значение!\n");
                }
            }
        }
    }
}
