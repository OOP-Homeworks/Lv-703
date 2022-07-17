using System;
using System.Collections.Generic;
using System.Text;

namespace Homework8
{
    internal class Square : Shape
    {
        private double side;
        public double Side
        {
            get { return side; }
        }
        public Square(string name, double side) : base(name)
        {
            this.side = side;
        }
        public override double Area()
        {
            return side * side;
        }
        public override double Perimetr()
        {
            return 4 * side;
        }
        public override void Print()
        {
            Console.WriteLine($"The square {Name} has side {Side}. It's perimetr = {this.Perimetr()} and area = {this.Area()}");
        }
    }
}
