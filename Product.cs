using System;
using System.Globalization;

namespace Storage_Control
{
    internal class Product
    {
        private string _name;
        private int _amount;
        private double _price;

        public Product(string name, double price, int amount)
        {
            _name = name;
            _price = price;
            _amount = amount;
        }
        public string GetName()
        {
            return _name;
        }
        public void SetName(string name)
        {
            if(name != null && name.Length > 1)
            {
                _name = name;
            }
            
        }
        /*
        public Product(string name, double price) //iniciar quantidade igual a zero
        {
            Name = name;
            Price = price;
            Amount = 0;
        }*/

        public double TotalValue()
        {
            return _price * _amount;
        }
        public override string ToString()
        {
            return "Product name: " + _name 
                + ". Price: US$ " + _price.ToString("F2", CultureInfo.InvariantCulture) 
                + ". Amount: " + _amount.ToString() 
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
