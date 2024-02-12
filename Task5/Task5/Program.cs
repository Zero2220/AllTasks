namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count =Convert.ToInt32(Console.ReadLine());
            Product[] products = new Product[count];

            Console.WriteLine("Productun adini daxil edin");
            string name = Console.ReadLine();
            Console.WriteLine("Productun Priceni daxil edin ");
            int price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Typei daxil edin");
            string type = Console.ReadLine();

            Product product = new Product()
            {
                Name = name,
                Price = price,
                Type = Type.Baker


            };


        }
    }
}
 