using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClass_Inheritance
{
    public class Rectangle : Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public Rectangle() : base()
        {
            Width = 0;
            Height = 0;
        }

        public Rectangle(int width, int height) : base()
        {
            Width = width;
            Height = height;
        }

        public Rectangle(string name, int width, int height) : base()
        {
            Name = name;
            Width = width;
            Height = height;
        }

        public override double CalcArea()
        {
            double area = Width * Height;
            return area;
        }
    }
}
