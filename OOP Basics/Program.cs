namespace OOP_Basics
{
    class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }
    }

    class Customer : Person
    {
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

            Person person = new Customer(10000);

            Customer customer = (Customer)person;
        }
    }
}
