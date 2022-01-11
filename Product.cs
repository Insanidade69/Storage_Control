using System;
using System.Globalization;

namespace Storage_Control
{
    internal class Product
    {

        public double TotalValue()
        {
        }
        public override string ToString()
        {
                + ". Total Value: US$ " + TotalValue().ToString("F2", CultureInfo.InvariantCulture);
        }
        public void AddProduct(int amount)
        {
            _amount += amount;
        }
        public void RemoveProduct(int amount)
        {
            _amount -= amount;
        }
    }
}
