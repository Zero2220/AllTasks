using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class ProductList
    {
        private string[] products = new string[3];

        
        public string this[int index]
        {

            get
            {

                return products[index];
            }

           
            set
            {

                products[index] = value;
            }
        }
    }
}
