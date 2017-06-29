using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OpinionPoll
{


   public class StartUp
    {

       public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List <Person> people = new List<Person>();

            for (int i = 0; i < n; i++)
            {
                string[] personInfo = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                Person person = new Person(personInfo[0],int.Parse(personInfo[1]));

                people.Add(person);
            }


            people
            .Where(person => person.age > 30)
            .OrderBy(person => person.name)
            .ToList()
            .ForEach(x => Console.WriteLine($"{x.name} - {x.age}"));



        }
    }
}
