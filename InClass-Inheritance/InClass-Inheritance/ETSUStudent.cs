using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClass_Inheritance
{
    public class ETSUStudent : Student
    {
        public string ENumber { get; set; }

        public ETSUStudent() : base()
        {
            ENumber = "E00000000";
        }

        public override string ToString()
        {
            string info = base.ToString();

            info += $"\nE-Number: {ENumber}";

            return info;
        }
    }
}
