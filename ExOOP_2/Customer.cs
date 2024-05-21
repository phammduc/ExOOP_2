using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExOOP_2
{
    public class Customer : Person
    {
        private int balance;

        public Customer(string name, string address, int balance)
            : base(name, address)
        {
            this.balance = balance;
        }

        public override void Display()
        {
            Console.WriteLine($"Name: {name}, Address: {address}, Balance: {balance}");
        }

        public int GetBalance()
        {
            return balance;
        }
    }
}
