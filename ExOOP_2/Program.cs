namespace ExOOP_2
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            List<Customer> customers = new List<Customer>();

            // Menu
            bool running = true;
            while (running)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Add a new Employee");
                Console.WriteLine("2. Add a new Customer");
                Console.WriteLine("3. Find the Employee with the highest salary");
                Console.WriteLine("4. Find the Customer with the lowest balance");
                Console.WriteLine("5. Find Employee by name");
                Console.WriteLine("6. Exit");
                Console.Write("Choose an option: ");
                int choice;
                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        AddEmployee(employees);
                        break;
                    case 2:
                        AddCustomer(customers);
                        break;
                    case 3:
                        FindHighestSalaryEmployee(employees);
                        break;
                    case 4:
                        FindLowestBalanceCustomer(customers);
                        break;
                    case 5:
                        FindEmployeeByName(employees);
                        break;
                    case 6:
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static void AddEmployee(List<Employee> employees)
        {
            Console.Write("Enter name: ");
            string name = Console.ReadLine();
            Console.Write("Enter address: ");
            string address = Console.ReadLine();
            int salary;
            while (true)
            {
                try
                {
                    Console.Write("Enter salary: ");
                    salary = int.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }

            employees.Add(new Employee(name, address, salary));
        }

        static void AddCustomer(List<Customer> customers)
        {
            Console.Write("Enter name: ");
            string name = Console.ReadLine();
            Console.Write("Enter address: ");
            string address = Console.ReadLine();
            int balance;
            while (true)
            {
                try
                {
                    Console.Write("Enter balance: ");
                    balance = int.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }

            customers.Add(new Customer(name, address, balance));
        }

        static void FindHighestSalaryEmployee(List<Employee> employees)
        {
            if (employees.Count == 0)
            {
                Console.WriteLine("No employees found.");
                return;
            }

            var highestSalaryEmployee = employees.OrderByDescending(emp => emp.GetSalary()).First();
            Console.WriteLine("Employee with the highest salary:");
            highestSalaryEmployee.Display();
        }

        static void FindLowestBalanceCustomer(List<Customer> customers)
        {
            if (customers.Count == 0)
            {
                Console.WriteLine("No customers found.");
                return;
            }

            var lowestBalanceCustomer = customers.OrderBy(cust => cust.GetBalance()).First();
            Console.WriteLine("Customer with the lowest balance:");
            lowestBalanceCustomer.Display();
        }

        static void FindEmployeeByName(List<Employee> employees)
        {
            Console.Write("Enter employee name: ");
            string name = Console.ReadLine();
            var employee = employees.FirstOrDefault(emp => emp.GetName().Equals(name, StringComparison.OrdinalIgnoreCase));
            if (employee != null)
            {
                Console.WriteLine("Employee found:");
                employee.Display();
            }
            else
            {
                Console.WriteLine("Employee not found.");
            }
        }
    }
}
