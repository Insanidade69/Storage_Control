using System;
using System.Globalization;

namespace Storage_Control
{
    class Program
    {
        static void Main(string[] args)
        {
            Product p = new Product();

            Console.WriteLine("-=-=-=-=-=-=-= Storage Control =-=-=-=-=-=-=-");
            Console.WriteLine("What infos of product?");
            Console.Write("Name: ");
            p.Name = Console.ReadLine();

            Console.WriteLine("What price of product?");
            Console.Write("Price: US$ ");
            p.Price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("What amount in storage of product?");
            Console.Write("Amount: ");
            p.Amount = int.Parse(Console.ReadLine());

            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");

            Console.WriteLine("Product in storage: " + p);
        }
    }
}