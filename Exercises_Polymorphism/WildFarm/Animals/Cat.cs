namespace WildFarm.Animals
{
    public class Cat : Felime
    {
        public string Breed { get; set; }
        public Cat(string name, string type, double weight, string livingRegion,string breed) : base(name, type, weight,livingRegion)
        {
            this.Breed = breed;
        }

        public override string MakeSound()
        {
            return "Meowwww";
        }

        public override string ToString()
        {
            return $"{this.Type}[{this.Name}, {this.Breed}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}