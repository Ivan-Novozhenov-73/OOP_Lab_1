using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_namespace
{
    internal class Bank
    {
        public string _bankName;            // название банка
        private int _countDeposits;         // кол-во депозитов
        private float _amountDeposits;      // сумма депозитов
        private float _interestRate;        // процентная ставка
        private int _numClients;            // кол-во клиентов
        private int _yearFoundation;        // год основания
        private string _location;           // расположение

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

        public void print()
        {
            Console.WriteLine($"Название банка: {_bankName}");
            Console.WriteLine($"Количество депозитов: {_countDeposits}");
            Console.WriteLine($"Сумма депозитов: {_amountDeposits}");
            Console.WriteLine($"Процентная ставка: {_interestRate}");
            Console.WriteLine($"Количество клиентов: {_numClients}");
            Console.WriteLine($"Год основания: {_yearFoundation}");
            Console.WriteLine($"Расположение: {_location}");
        }
    }
}
