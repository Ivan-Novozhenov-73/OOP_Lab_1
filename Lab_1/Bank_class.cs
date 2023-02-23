using System;

namespace Bank_namespace
{
    internal class Bank
    {
        /* ПОЛЯ */
        public string _bankName;            // название банка
        private int _countDeposits;         // кол-во депозитов
        private double _amountDeposits;      // сумма депозитов
        private float _interestRate;        // процентная ставка
        private int _numClients;            // кол-во клиентов
        private int _yearFoundation;        // год основания
        private string _location;           // расположение


        /* МЕТОДЫ */
        // конструктор без параметров
        public Bank()
        {
            _bankName = "Банк";
            _countDeposits = 0;
            _amountDeposits = 0;
            _interestRate = 0;
            _numClients = 0;
            _yearFoundation = 1970;
            _location = "Город";
        }

        // конструктор с одним параметром
        public Bank(string bankName)
        {
            _bankName = bankName;
            _countDeposits = 0;
            _amountDeposits = 0;
            _interestRate = 0;
            _numClients = 0;
            _yearFoundation = 1970;
            _location = "Город";
        }

        // конструктор с двумя параметрами
        public Bank(string bankName, int countDeposits)
        {
            _bankName = bankName;
            _countDeposits = countDeposits;
            _amountDeposits = 0;
            _interestRate = 0;
            _numClients = 0;
            _yearFoundation = 1970;
            _location = "Город";
        }

        // конструктор с семью параметрами
        public Bank(string bankName, int countDeposits, double amountDeposits, float interestRate,
            int numClients, int yearFoundation, string location)
        {
            _bankName = bankName;
            _countDeposits = countDeposits;
            _amountDeposits = amountDeposits;
            _interestRate = interestRate;
            _numClients = numClients;
            _yearFoundation = yearFoundation;
            _location = location;
        }

        // переопределение метода ToString()
        public override string ToString()
        {
            return $"Название банка: {_bankName}\n" +
                $"Количество депозитов: {_countDeposits}\n" +
                $"Сумма депозитов: {_amountDeposits}$\n" +
                $"Процентная ставка: {_interestRate}%\n" +
                $"Количество клиентов: {_numClients}\n" +
                $"Год основания: {_yearFoundation}\n" +
                $"Расположение: {_location}\n";
        }

        // вывод полей класса
        public void print()
        {
            Console.WriteLine($"Название банка: {_bankName}");
            Console.WriteLine($"Количество депозитов: {_countDeposits}");
            Console.WriteLine($"Сумма депозитов: {_amountDeposits}$");
            Console.WriteLine($"Процентная ставка: {_interestRate}%");
            Console.WriteLine($"Количество клиентов: {_numClients}");
            Console.WriteLine($"Год основания: {_yearFoundation}");
            Console.WriteLine($"Расположение: {_location}\n");
        }
    }
}
