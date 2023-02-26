using System;

namespace Bank_namespace
{
    class Bank
    {
        /* ПОЛЯ */
        public string _bankName;            // название банка
        private int _countDeposits;         // кол-во депозитов
        private double _amountDeposits;     // сумма депозитов
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



        // вывод кол-ва депозитов
        public int get_countDeposits()
        {
            return _countDeposits;
        }

        // вывод суммы депозитов
        public double get_amountDeposits()
        {
            return _amountDeposits;
        }

        // вывод процентной ставки
        public float get_interestRate()
        {
            return _interestRate;
        }

        // вывод кол-ва клиентов
        public int get_numClients()
        {
            return _numClients;
        }

        // вывод года основания
        public int get_yearFoundation()
        {
            return _yearFoundation;
        }

        // вывод расположения
        public string get_location()
        {
            return _location;
        }



        // установить название банка
        public void set_bankName(string bankName)
        {
            _bankName = bankName;
        }

        // установить кол-во депозитов
        public void set_countDeposits(int countDeposits)
        {
            _countDeposits = countDeposits;
        }

        // установить сумму депозитов
        public void set_amountDeposits(double amountDeposits)
        {
            _amountDeposits = amountDeposits;
        }

        // установить процентную ставку
        public void set_interestRate(float interestRate)
        {
            _interestRate = interestRate;
        }

        // установить кол-во клиентов
        public void set_numClients(int numClients)
        {
            _numClients = numClients;
        }

        // установить год основания
        public void set_yearFoundation(int yearFoundation)
        {
            _yearFoundation = yearFoundation;
        }

        // установить расположение
        public void set_location(string location)
        {
            _location = location;
        }


    }
}
