using System.Collections;
using WildFarm.Foods;

namespace WildFarm.Factories
{
    public class FoodFactory
    {
        public static Food GetFood(string[] tokens)
        {
            var foodType = tokens[0];
            int foodQuantity = int.Parse(tokens[1]);

            if (foodType == "Vegetable")
            {
                return new Vegetable(foodQuantity);
            }

            return new Meat(foodQuantity);
        }
    }
}