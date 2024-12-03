using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Salmon : Animal, ISwimmable
    {
        public void Swim()
        {
            Console.WriteLine("I can swim really fast!");
        }

        public void ToString()
        {
            Console.WriteLine("I'm a Salmon, I do Glub");
        }
    }
}
