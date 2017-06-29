using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace official
{
   public class StartUp
    {

        public static void Main()
        {
            string name = Console.ReadLine();

            Person person = new Person(name);

            person.sayHello();

        }

        
    }
}
