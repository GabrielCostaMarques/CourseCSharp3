using System.Globalization;
using System;

namespace CourseCSharp3.Comparable.Entities
{
    internal class Employee : IComparable
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(string csvEmployee)
        {
            string[] vect = csvEmployee.Split(',');
            Name = vect[0];
            Salary = double.Parse(vect[1], CultureInfo.InvariantCulture);
        }

        public override string ToString()
        {
            return Name + ", " + Salary.ToString(CultureInfo.InvariantCulture);
        }

        public int CompareTo(object? obj)
        {
            if (!(obj is Employee))
            {
                throw new ArgumentException("Comparing error: argument is not avaible");
            }
            Employee other = obj as Employee;
            return Name.CompareTo(other.Name);
        }
    }
}
