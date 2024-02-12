using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Product
    {
        public Product() 
        {
            
            No = count++;


        }
        public static int count=0;
        public int No;
        public string Name;
        public double Price;
        public Type Type;
    }
}
