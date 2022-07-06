using System;
using System.Collections.Generic;
using System.Text;

namespace Homework5
{
    internal class Plane : IFlyable
    {
        string mark;
        int highFly;
        public Plane(string mark, int highFly)
        {
            this.mark = mark;
            this.highFly = highFly;
        }
        public void Fly()
        {
            Console.WriteLine($"The mark of plane is {mark} and it is able to fly at the high of {highFly} m.");
        }
    }
}
