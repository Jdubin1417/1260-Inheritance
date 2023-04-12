using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClass_Inheritance
{
    public abstract class Shape
    {
        public string Name { get; set; }

        public Shape()
        {
            Name = "Shape";
        }

        public abstract double CalcArea();

        public override string ToString()
        {
            return "I am a shape";
        }
    }
}
