using System;
namespace OOP_Basics
{
    class Person
    {
        public string Name { get; set; }

        public Person(string name)
        {
            Name = name;
            Console.WriteLine("Person");
        }

        protected string Description()
        {
            return "Person";
        }
    }

    class Customer : Person
    {
        public bool GoldCustomer;

        private int _age;

        public Customer(string name, int age) : base(name)
        {
            Console.WriteLine("Customer");
            Age = age;
        }

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

        public string Description
        {
            get
            {
                return "Customer has " + Age + " and has a name " + Name;
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


        private int _creditAmount;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer("Adam", 10);
            Console.WriteLine(customer.Description);
        }
    }
}
