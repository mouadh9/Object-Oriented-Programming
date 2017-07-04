using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Problem1.People
{
    class Program
    {
        static void Main(string[] args)
        {
            //  MethodInfo oldestMemberMethod = typeof(Family).GetMethod("GetOldestMember");
            //  MethodInfo addMemberMethod = typeof(Family).GetMethod("AddMember");
            //  if (oldestMemberMethod == null || addMemberMethod == null)
            //  {
            //      throw new Exception();
            //  }
            //
            //  var numberOfpeople = int.Parse(Console.ReadLine());
            //  var family = new Family();
            //  for (int i = 0; i < numberOfpeople; i++)
            //  {
            //      var input = Console.ReadLine().Split();
            //      string name = input[0];
            //      int age = int.Parse(input[1]);
            //      var person = new Person(name,age);
            //      family.AddMember(person);
            //  }
            //  var olderstPerson = family.GetOldestMember();
            //  Console.WriteLine($"{olderstPerson.Name} {olderstPerson.Age}");


            var numberOfpeople = int.Parse(Console.ReadLine());
            SortedDictionary<string,int> people = new SortedDictionary<string, int>();
            for (int i = 0; i < numberOfpeople; i++)
            {
                var input = Console.ReadLine().Split();
                string name = input[0];
                int age = int.Parse(input[1]);
                people.Add(name,age);
            }
            foreach (var person in people)
            {
                if (person.Value > 30)
                {
                    Console.WriteLine($"{person.Key} - {person.Value}");
                }
            }
        }
    }
}
