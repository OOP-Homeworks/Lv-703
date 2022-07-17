using System;
using System.Collections.Generic;
using System.Text;

namespace Homework8
{
    internal class Circle : Shape
    {
        private double radius;
        public double Radius { get { return radius; } }
        public Circle(string name, double radius) : base(name)
        {
            this.radius = radius;
        }
        public override double Area()
        {
            return Math.PI * radius * radius;
        }
        public override double Perimetr()
        {
            return Math.PI * radius * 2;
        }
        public override void Print()
        {
            Console.WriteLine($"The circle {Name} has radius {Radius}. It's perimetr = {this.Perimetr()} and area = {this.Area()}");
        }
    }
}
