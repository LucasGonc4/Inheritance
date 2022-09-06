using System;
using System.Globalization;
using Exercicio.Entities;


namespace Course
{
    class Program
    {
        static void Main(string[] args) 
        {
            List<Employee> list = new List<Employee>();

            Console.WriteLine("How much employers? ");
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Employer data #{i}");
                Console.Write("Outsourced? (y/n): ");
                char c = char.Parse(Console.ReadLine());
                Console.WriteLine("Name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.WriteLine("Value per hour: ");
                double valueperhour = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                if (c == 'y')
                {
                    Console.WriteLine("Additional charge: ");
                    double additionalcharge = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    list.Add (new Outsource_employee(name, hours, valueperhour, additionalcharge));
                }
                else
                {
                    list.Add(new Employee(name, hours, valueperhour));
                }
            }
            Console.WriteLine("PAYMENTS: ");
            foreach (Employee emp in list)
            {
                Console.WriteLine(emp.Name + " - $ " + emp.Payment().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
