using System;
using System.Collections.Generic;
using System.Text;

namespace Mankind
{
    public class Worker : Human
    {
        private decimal salary;
        private decimal workingHours;

        public decimal WorkingHours
        {
            get { return workingHours; }
            private set
            {
                if (value < 1 || value > 12)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");
                }
                workingHours = value;
            }
        }

        public decimal Salary
        {
            get { return salary; }
            private set
            {
                if (value <= 10)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: weekSalary");
                }
                salary = value;
            }
        }

        public Worker(string firstName, string lastName, decimal salary, decimal workingHours)
            : base(firstName, lastName)
        {
            Salary = salary;
            WorkingHours = workingHours;
        }

        private decimal CalculateSalaryPerHour()
        {
            return (this.salary / this.workingHours) / 5;
        }

        public override string ToString()
        {
            StringBuilder workerBuilder = new StringBuilder();
            workerBuilder.AppendLine($"First Name: {this.FirstName}");
            workerBuilder.AppendLine($"Last Name: {this.LastName}");
            workerBuilder.AppendLine($"Week Salary: {this.salary:F2}");
            workerBuilder.AppendLine($"Hours per day: {this.workingHours:F2}");
            workerBuilder.AppendLine($"Salary per hour: {this.CalculateSalaryPerHour():F2}");
            return workerBuilder.ToString();
        }
    }
}
