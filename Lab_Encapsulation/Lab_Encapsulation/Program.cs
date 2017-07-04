using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            //  var lines = int.Parse(Console.ReadLine());
            //  var persons = new List<Person>();
            //  for (int i = 0; i < lines; i++)
            //  {
            //      try
            //      {
            //          var cmdArgs = Console.ReadLine().Split();
            //          var person = new Person(cmdArgs[0],
            //              cmdArgs[1],
            //              int.Parse(cmdArgs[2]),
            //              double.Parse(cmdArgs[3]));
            //
            //          persons.Add(person);
            //      }
            //      catch (ArgumentException e)
            //      {
            //          Console.WriteLine(e);
            //      }
            //  }
            //  var bonus = double.Parse(Console.ReadLine());
            //
            //  persons.ForEach(p => p.IncreaseSalary(bonus));
            //  persons.ForEach(p => Console.WriteLine(p.ToString()));
            var lines = int.Parse(Console.ReadLine());
            var team = new Team("Team");
            for (int i = 0; i < lines; i++)
            {
                try
                {
                    var cmdArgs = Console.ReadLine().Split();
                    var person = new Person(cmdArgs[0],
                        cmdArgs[1],
                        int.Parse(cmdArgs[2]),
                        double.Parse(cmdArgs[3]));

                    team.AddPlayer(person);
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e);
                }
            }
            Console.WriteLine($"First team have {team.FirstTeam.Count} players");
            Console.WriteLine($"Reserve  team have {team.ReserveTeam.Count} players");


        }
    }
}
