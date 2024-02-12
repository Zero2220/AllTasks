using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Circle:Shapes
    {

        public double radius;

        public override double CalculateArea()
        {
            return (radius*radius)*3.15;
        }
    }
}
