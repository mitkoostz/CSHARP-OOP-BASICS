using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace official
{
    class Person
    {
        public string name;

       public Person(string name)
        {
            this.name = name;
        }

        public void sayHello()
        {
            Console.WriteLine($"{this.name} says Hello!");
        }

    }
}
