using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClass_Inheritance
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        private int _age;

        public int Age
        {
            get { return _age; }
            set 
            {
                if (value < 0)
                    throw new AgeException("Age cannot be a negative value.");
                _age = value; 
            }
        }

        public Person()
        {
            FirstName = "Bob";
            LastName = "Jones";
            Age = 18;
        }

        public Person(string first, string last, int age)
        {
            FirstName = first;
            LastName = last;
            Age = age;
        }

        public Person(Person other)
        {
            FirstName = other.FirstName;
            LastName = other.LastName;
            Age = other.Age;
        }

        public void HaveBirthday()
        {
            Age++;
        }

        public override string ToString()
        {
            string info = "";

            info += $"\nName: {FirstName} {LastName}";
            info += $"\nAge: {Age}";

            return info;
        }
    }
}
