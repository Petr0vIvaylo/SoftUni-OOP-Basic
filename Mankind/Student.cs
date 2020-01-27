using System;
using System.Collections.Generic;
using System.Text;

namespace Mankind
{
    public class Student : Human
    {
        private string facultyNumber;

        public string FacultyNumber
        {
            get { return facultyNumber; }
            private set
            {
                if (value.Length < 5 || value.Length > 10)
                {
                    throw new ArgumentException("Invalid faculty number!");
                }
                foreach (var item in value)
                {
                    if (!char.IsLetterOrDigit(item))
                    {
                        throw new ArgumentException("Invalid faculty number!");
                    }
                }
                facultyNumber = value;
            }
        }
        public override string ToString()
        {
            StringBuilder studentBuilder = new StringBuilder();
            studentBuilder.AppendLine($"First Name: {this.FirstName}");
            studentBuilder.AppendLine($"Last Name: {this.LastName}");
            studentBuilder.AppendLine($"Faculty number: {this.facultyNumber}");
            
            return studentBuilder.ToString();
        }

        public Student(string firstName, string lastName, string facultyNumber)
            : base(firstName, lastName)
        {
            FacultyNumber = facultyNumber;
        }
    }
}
