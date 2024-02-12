using System.ComponentModel;
using System.ComponentModel.Design;

namespace Task4;

    internal class Program
    {


       static void Main(string[] args)
       {
        string choice;
        Market market = new Market();
           do
           {
            
            
            
                Console.WriteLine("1. Add Product");
                Console.WriteLine("2. Remove Product");
                Console.WriteLine("3. Sell Product");
                Console.WriteLine("4. Find Product By No");
                Console.WriteLine("5. Find Index By No");
                Console.WriteLine("0. Exit");
                Console.Write("Enter your choice: ");
                 choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":

                        Console.WriteLine("Adding Product...");
                        Product product = new Product();
                        market.AddProduct(product);
                        break;
                    case "2":

                        Console.WriteLine("Removing Product...");
                        Console.WriteLine ("Noyu daxil edin ");
                        int No = Convert.ToInt32(Console.ReadLine());
                        market.RemoveProductByNo(No);

                        break;
                    case "3":

                        Console.WriteLine("Selling Product...");
                        Console.WriteLine("ssatmaq istediyiniz productun nomresini daxil edin ");
                        int no = Convert.ToInt32(Console.ReadLine());
                        market.Sell(no); 

                        break;
                    case "4":

                        Console.WriteLine("Finding Product By No...");
                        Console.WriteLine("Product Noyu daxil edin");
                        int no1 = Convert.ToInt32(Console.ReadLine());
                        market.FindProductByNo(no1);
                        break;
                    case "5":

                        Console.WriteLine("Finding Index By No...");
                        Console.WriteLine("Product Noyu daxil edin");
                        int no2 = Convert.ToInt32(Console.ReadLine());
                        market.FindIndexByNo(no2);


                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a number from 1 to 6.");
                        break;
                }


            
        
           }
           while (choice!="0");
       }

               
    }


  

