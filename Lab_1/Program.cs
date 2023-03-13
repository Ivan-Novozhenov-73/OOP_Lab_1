using System;

namespace Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            UI.print_info();

            Bank bank = new Bank();
            Bank sber = new Bank("Сбер");
            Bank tinkoff = new Bank("Тинькофф", 100);
            Bank alpha = new Bank("Альфа-банк", 5000, 4788862.57, 5.3f, 22500, 1990, "Москва");
 
            Console.WriteLine("Выберите банк");
            Console.WriteLine("1) " + bank._bankName);
            Console.WriteLine("2) " + sber._bankName);
            Console.WriteLine("3) " + tinkoff._bankName);
            Console.WriteLine("4) " + alpha._bankName);

            bool flag = true;
            while (flag)
            {
                Console.Write("Введите число: ");
                string num = Console.ReadLine();
                switch (num)
                {
                    case "1":
                        flag = false;
                        UI.print_info2(ref bank);
                        break;
                    case "2":
                        flag = false;
                        UI.print_info2(ref sber);
                        break;
                    case "3":
                        flag = false;
                        UI.print_info2(ref tinkoff);
                        break;
                    case "4":
                        flag = false;
                        UI.print_info2(ref alpha);
                        break;
                    default:
                        Console.WriteLine("Неверное значение!\n");
                        continue;
                }
            }
        }
    }
}