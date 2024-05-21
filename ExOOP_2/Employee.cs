using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExOOP_2
{
    public class Employee : Person
    {
        private int salary;

        public Employee(string name, string address, int salary)
            : base(name, address)
        {
            this.salary = salary;
        }

        public override void Display()
        {
            Console.WriteLine($"Name: {name}, Address: {address}, Salary: {salary}");
        }

        public int GetSalary()
        {
            return salary;
        }
    }
}
