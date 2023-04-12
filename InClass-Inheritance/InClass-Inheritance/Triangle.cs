using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClass_Inheritance
{
    public class Triangle : Shape
    {
        public int Base { get; set; }
        public int Height { get; set; }

        public Triangle() : base()
        {
            Base = 0;
            Height = 0;
        }

        public Triangle(int triBase, int height) : base()
        {
            Base = triBase;
            Height = height;
        }

        public Triangle(string name, int triBase, int height) : base()
        {
            Name = name;
            Base = triBase;
            Height = height;
        }

        public override double CalcArea()
        {
            double area = 0.5 * Base * Height;
            return area;
        }
    }
}
