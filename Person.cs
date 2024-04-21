using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maga_test
{
    public class Person
    {
        public string Name { get; private set; }
        public string FirstName { get; private set; }
        public DateTime Birthday { get; private set; }
        public int Age { get; private set; }

        public Person(string name, string firstName, DateTime birthday)
        {
            Name = String.IsNullOrEmpty(name) ? "???" : name;
            FirstName = String.IsNullOrEmpty(firstName) ? "???" : firstName;
            Birthday = birthday;
            Age = (int)Math.Floor((DateTime.Now - birthday).TotalDays / 365.2425);
        }
        public string Print()
        {
            return $"└--- {FirstName} {Name} {Birthday.ToShortDateString()} {Age}";
        }
    }
}
