using System;
using System.Globalization;

namespace Storage_Control
{
    internal class Product
    {
        public string Name;
        public int Amount;
        public double Price;

        public double TotalValue()
        {
            return Price * Amount;
        }
        public override string ToString()
        {
            return "Product name: " + Name 
                + ". Price: US$ " + Price.ToString("F2", CultureInfo.InvariantCulture) 
                + ". Amount: " + Amount.ToString() 
                + ". Total Value: US$ " + TotalValue().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
