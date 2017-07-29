namespace WildFarm.Animals
{
    public abstract class Mammal : Animal
    {
        public string LivingRegion { get; set; }

        protected Mammal(string name, string type, double weight, string livingRegion) : base(name, type, weight)
        {
            this.LivingRegion = livingRegion;
        }

        public override string ToString()
        {
            return $"{this.Type}[{this.Name}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}