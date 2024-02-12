using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Market : IMarket, Ireporter
    {
        Product[] Products = new Product[10];
        private static double AlcoholPercentLimit = 4;
        private static int AlcoholProductLimit = 4;
        public int TotalAmount;

        public DrinkProduct[] GetDrinks()
        {
            int count = 1;
            DrinkProduct[] drinkProducts = new DrinkProduct[count];

            for (int i = 0; i < Products.Length; i++)
            {
                if (Products[i] is DrinkProduct)
                {
                    drinkProducts[i] = (DrinkProduct)Products[count];
                    count++;

                }

            }
            return drinkProducts;


        }






        public DrinkProduct[] GetAlcoholDrinks()
        {
            int count = 1;
            DrinkProduct drink;
            DrinkProduct[] drinkProducts = new DrinkProduct[count];

            for (int i = 0; i < Products.Length; i++)
            {

                if (Products[i] is DrinkProduct)
                {
                    drink = (DrinkProduct)Products[i];
                    if (drink.AlcoholPercent > 0)
                    {
                        drinkProducts[i] = (DrinkProduct)Products[count];
                        count++;
                    }


                }

            }
            return drinkProducts;

        }




        public DrinkProduct[] GetNonAlcoholDrinks()
        {
            int count = 1;
            DrinkProduct drink;
            DrinkProduct[] drinkProducts = new DrinkProduct[count];

            for (int i = 0; i < Products.Length; i++)
            {

                if (Products[i] is DrinkProduct)
                {
                    drink = (DrinkProduct)Products[i];
                    if (drink.AlcoholPercent == 0)
                    {
                        drinkProducts[i] = (DrinkProduct)Products[count];
                        count++;
                    }


                }

            }
            return drinkProducts;
        }




        public Product[] GetExpiredProducts()
        {
            int count = 1;
            Product[] products = new Product[count];
            for (int i = 0; i < Products.Length; i++)
            {

                if (Products[i].ExpireDate < DateTime.Now)
                {
                    products[count] = Products[i];
                    count++;
                }

            }
            return products;
        }




        public void RemoveExpiredProducts()
        {
            int count = 0;
            Product[] products = new Product[count];

            for (int i = 0; i < Products.Length; i++)
            {
                if (Products[i].ExpireDate > DateTime.Now)
                {
                    count++;
                    products[count] = Products[i];
                }

            }
            Array.Resize(ref products, count);
            Products = products;
        }

        

        public void RemoveProductByNo(int productNo)
        {
            int count = 0;
            Product[] products = new Product[count];

            for (int i = 0; i < Products.Length; i++)
            {
                if (Products[i].No !=productNo)
                {
                    count++;
                    products[count] = Products[i];
                }

            }
            Array.Resize(ref products, count);
            Products = products;
        }

       
       

        public void FindByNo(int productNo)
        {
            for (int i =0;i<Products.Length;i++)
            {
                if(productNo == Products[i].No)
                {
                    Console.WriteLine("Productun adi:" + Products[i].Name);
                }
            }
        }

        public void FindIndexByNo(int productNo)
        {
            for (int i = 0; i < Products.Length; i++)
            {
                if (productNo == Products[i].No)
                {
                    Console.WriteLine("Index:" +i);
                }
            }
        }

        public int GetAllProfit()
        {
            return TotalAmount;
        }


        public void AddProduct(Product product)
        {
            Array.Resize(ref Products, Products.Length+1);
            Products[Products.Length-1] = product;
        }

        public void Sell(int no )
        {
            for(int i = 0; i < Products.Length; i++)
            {
                if (Products[i].No == no)
                {
                    TotalAmount++;
                }
            }
            
        }
        public void FindProductByNo(int productNo)
        {
            for( int i = 0;i < Products.Length; i++)
            {
                if (Products[i].No == productNo)
                {
                    Console.WriteLine("ProductNO");
                }
            }
        }
    }
}
