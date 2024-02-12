using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal interface IMarket
    {
        public void AddProduct(Product product);
        public void RemoveProductByNo(int productNo);
        

        
        

        public void FindByNo(int productNo);


        public void FindIndexByNo(int productNo);

        

    }
}
