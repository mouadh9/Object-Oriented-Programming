using System;
using System.Collections.Generic;
using System.Linq;

namespace Pizza_Calories.Models
{
    public class Pizza
    {
        public Pizza(string name, int toppingsAmount)
        {
            this.Name = name;
            this.ToppingsAmount = toppingsAmount;
            this.toppings = new List<Topping>();
        }

        private string name;
        private int toppingsAmount;
        private List<Topping> toppings;
        private Dough dough;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length > 15)
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }
                this.name = value;
            }
        }

        public int ToppingsAmount
        {
            get
            {
                return this.toppingsAmount;
            }
            set
            {
                if (value < 0 || value > 10)
                {
                    throw new ArgumentException("Number of toppings should be in range [0..10].");
                }
                this.toppingsAmount = value;
            }
        }

        public Dough Dough
        {
            set
            {
                this.dough = value;
            }
        }

        public void AddTopping(Topping topping)
        {
            this.toppings.Add(topping);
        }

        public double CalculateCalories()
        {
            return this.dough.CalculateCalories() + this.toppings.Sum(t => t.CalculateCalories());
        }


    }
}