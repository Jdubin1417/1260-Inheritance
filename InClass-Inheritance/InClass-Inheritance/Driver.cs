using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClass_Inheritance
{
    public class Driver
    {
        public static void Main()
        {
            Student bob = new Student();

            Console.WriteLine(bob.FirstName);
            Console.WriteLine(bob.LastName);
            Console.WriteLine(bob.Age);
            Console.WriteLine(bob.Major);
            Console.WriteLine(bob.GPA);

            Console.WriteLine(bob.ToString());

            ETSUStudent bob2 = new ETSUStudent();
            Console.WriteLine(bob2.ToString());

            Person p = new Student("Joe", "Johnson", 45, "Psychology", 3.42);

            Console.WriteLine(p);

            //Student s = new Person(); //opposite way does not work

            if(p is Student)
                Console.WriteLine(((Student)p).Major);

            //

            //Shape s = new Shape();
            Rectangle r = new Rectangle(5, 4);
            Console.WriteLine(r.CalcArea());

            Triangle t = new Triangle(10, 3);
            Console.WriteLine(t.CalcArea());

            Shape s = new Rectangle(5, 4);
            Console.WriteLine(s.CalcArea());
        }
    }
}
