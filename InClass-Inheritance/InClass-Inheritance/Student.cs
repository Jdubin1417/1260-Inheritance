using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClass_Inheritance
{
    public class Student : Person
    {
        public string Major { get; set; }
        public double GPA { get; set; }

        public Student() : base()
        {
            Major = "Computing";
            GPA = 0.0;
        }

        public Student(string firstName, string lastName, int age, 
            string major, double gpa) : base(firstName, lastName, age)
        {
            Major = major;
            GPA = gpa;
        }

        public override string ToString()
        {
            string info = base.ToString();

            info += $"\nMajor: {Major}";
            info += $"\nGPA: {GPA}";

            return info;
        }
    }
}
