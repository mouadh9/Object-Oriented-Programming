using WildFarm.Foods;

namespace WildFarm.Animals
{
    public abstract class Animal
    {
        protected string Name { get; set; }
        protected string Type { get; set; }
        protected double Weight { get; set; }
        protected int FoodEaten { get; set; }

        protected Animal(string name, string type, double weight)
        {
            Name = name;
            Type = type;
            Weight = weight;
        }

        public abstract string MakeSound();

        public virtual void Eat(Food food)
        {
            this.FoodEaten += food.Quantity;
        }
    }
}