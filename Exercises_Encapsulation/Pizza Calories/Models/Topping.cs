using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Calories.Models
{
    public class Topping
    {
        private const int MinWeight = 1;
        private const int MaxWeight = 50;

        private string type;
        private int weight;

        public Topping(string type, int weight)
        {
            this.Type = type;
            this.Weight = weight;
        }
        private string Type
        {
            set
            {
                if (value.ToLower() != "meat" && value.ToLower() != "veggies" && value.ToLower() != "cheese" && value.ToLower() != "sauce")
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }
                this.type = value;
            }
        }

        private int Weight
        {
            set
            {
                if (value < MinWeight || value > MaxWeight)
                {
                    throw new ArgumentException($"{this.type} weight should be in the range [1..50].");
                }
                this.weight = value;
            }
        }

        public double CalculateCalories()
        {
            double modifier;

            switch (this.type.ToLower())
            {
                case "meat":
                    modifier = 1.2;
                    break;;
                case "veggies":
                    modifier = 0.8;
                    break;
                case "cheese":
                    modifier = 1.1;
                    break;
                default:
                    modifier = 0.9;
                    break;
            }

            return 2 * this.weight * modifier;
        }
    }


}
