using System;
using System.Collections.Generic;

namespace ShoppingSpree
{
    public class Product
    {
        private string name;
        private decimal cost;

        public Product(string name, decimal price)
        {
            this.Name = name;
            this.cost = price;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name Empty!");
                }
                this.name = value;
            }
        }

        public decimal Cost
        {
            get { return this.cost; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Negative number for cost!");
                }
                this.cost = value;
            }
        }
    }
}