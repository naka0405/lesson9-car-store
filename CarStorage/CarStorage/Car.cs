using System;
using System.Collections.Generic;
using System.Text;

namespace CarStorage
{
    public class Car
    {
        private int _price = 0;
        public string Color { get; set; }
        public int Price
        {
            get { return _price; }
            set
            {
                if (value > 0)
                { _price = value; }
                else
                {
                    Console.WriteLine($"This price is invalid {value}!");
                }
            }
        }
        public string Name { get; set; }

        public double GetSale()
        {
            var saleSum = new Random().Next(5, 20);
            return Price - (saleSum / 100.0 * Price);
        }
        protected bool isColorValid(string color)
        {
            return Enum.TryParse(color, out EnumColors result);
        }
        private void TestMethod()
        {

        }

    }
}
