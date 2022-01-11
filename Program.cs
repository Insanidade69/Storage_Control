using System;
using System.Globalization;

namespace Storage_Control
{
    class Program
    {
        static void Main(string[] args)
        {
            Product p = new Product(" ", 0.00, 0);

            p.SetName(" ");

            /*
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-= Storage Control =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
            Console.WriteLine("What infos of product?");
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.WriteLine("What price of product?");
            Console.Write("Price: US$ ");
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("What amount in storage of product?");
            Console.Write("Amount: ");
            int amount = int.Parse(Console.ReadLine());

            Product p = new Product(name, price, amount);

            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");

            Console.WriteLine("Product in storage: " + p);

            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");

            Console.WriteLine("What amount of product do u want add?");
            Console.Write("Amount: ");
            p.AddProduct(int.Parse(Console.ReadLine()));

            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");

            Console.WriteLine("Product in storage: " + p);

            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");

            Console.WriteLine("What smount of product do u want remove?");
            Console.Write("Amount: ");
            p.RemoveProduct(int.Parse(Console.ReadLine()));

            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");

            Console.WriteLine("Product in storage: " + p);
            */
        }
    }
}