using System;
using System.Collections.Generic;
using System.Text;

namespace Homework5
{
    internal class Bird : IFlyable
    {
        string name;
        bool canFly;
        public Bird(string name, bool canFly)
        {
            this.name = name;
            this.canFly = canFly;
        }
        public void Fly()
        {
            if (this.canFly)
            {
                Console.WriteLine($"It's the bird of the {name} breed and it is able to fly. ");
            }
            else Console.WriteLine($"It's the bird of the {name} breed and it isn't able to fly. ");
        }
    }
}
