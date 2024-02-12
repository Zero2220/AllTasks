using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Rectangle:Shapes
    {
        public double Height;
        public double Width;


        public override double CalculateArea()
        {
            return Height*Width;
        }
    }
}
