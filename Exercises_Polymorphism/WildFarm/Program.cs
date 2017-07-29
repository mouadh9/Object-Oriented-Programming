using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Animals;
using WildFarm.Factories;
using WildFarm.Foods;

namespace WildFarm
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputLine;
            while ((inputLine = Console.ReadLine()) != "End")
            {
                var animalTokens = inputLine.Split(new[] { '\t', ' ', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                var foodTokens = Console.ReadLine().Split(new[] { '\t', ' ', '\n' }, StringSplitOptions.RemoveEmptyEntries);

                Animal animal = AnimalFactory.GetAnimal(animalTokens);
                Food food = FoodFactory.GetFood(foodTokens);

                Console.WriteLine(animal.MakeSound());
                try
                {
                    animal.Eat(food);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                Console.WriteLine(animal);
            }
        }
    }
}
