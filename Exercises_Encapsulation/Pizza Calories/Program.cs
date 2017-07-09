using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pizza_Calories.Models;

namespace Pizza_Calories
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var tokens = Console.ReadLine().Split(new []{' '}, StringSplitOptions.RemoveEmptyEntries);
                Dough dough = new Dough(tokens[1],tokens[2],int.Parse(tokens[3]));
                Console.WriteLine(dough.CalculateCalories());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
