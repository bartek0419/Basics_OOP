using System;
namespace OOP_Basics
{
    class Person
    {
        public string Name { get; set; }
    }

    class Customer : Person
    {
        public bool GoldCustomer;

        private int _age;

        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value < 0)
                {
                    _age = 0;
                }
                else
                {
                    _age = value;
                }
            }
        }
        public bool IsGoldCustomer
        {
            get
            {
                if (_creditAmount > 100000)
                    return true;
                else
                    return false;
            }
        }

        public Customer(int creditAmount)
        {
            this._creditAmount = creditAmount;
        }

        private int _creditAmount;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer(10000);
            customer.Age = 25;
            Console.WriteLine("Is Gold Customer : " + customer.IsGoldCustomer);
        }
    }
}
