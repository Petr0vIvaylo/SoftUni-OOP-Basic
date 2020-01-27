using System;
using System.Collections.Generic;
using System.Linq;

namespace CompanyRoster
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string name = input[0];
                decimal salary = decimal.Parse(input[1]);
                string position = input[2];
                string department = input[3];

                Employee currentEmployee = new Employee(name, salary, position, department);

                if (input.Length >= 5)
                {
                    if (input[4].Contains("@"))
                    {
                        string email = input[4];
                        currentEmployee.Email = email;
                    }
                    else
                    {
                        int age = int.Parse(input[4]);
                        currentEmployee.Age = age;
                    }
                }
                if (input.Length == 6 )
                {
                    int age = int.Parse(input[5]);
                    currentEmployee.Age = age;
                }
                
                employees.Add(currentEmployee);
            }

            var topDepartment = employees.GroupBy(x => x.Department)
                .ToDictionary(x => x.Key, y => y.Select(s => s))
                .OrderByDescending(s => s.Value.Average(x => x.Salary))
                .FirstOrDefault();

            Console.WriteLine($"Highest Average Salary: {topDepartment.Key}");
            foreach (var employee in topDepartment.Value.OrderByDescending(s => s.Salary))
            {
                Console.WriteLine($"{employee.Name} {employee.Salary:F2} {employee.Email} {employee.Age}");
            }
        }
    }
}
