using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Cat : Mammal, IWalkable
    {
        public string Sound => "Meow";
        public virtual void Move()
        {
            Console.WriteLine("Walking like a cat...");
        }
        public void ThrowOfTheTable()
        {
            Console.WriteLine("whooops");
        }

        public void Walk()
        {
            Console.WriteLine("I like walking on furniture and tables");
        }

        public void ToString()
        {
            Console.WriteLine("I'm a Cat, I do Meow");
        }
    }
}
