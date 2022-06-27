using System;

namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            int a;
            Console.Write("Enter the lenght of the side: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Area:{0}, Perimetr:{1}.", a * a, 4 * a);

            //Task 2
            string name;
            int age;
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
            Console.WriteLine($"How old are you, {name}?");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Hello {name}, you are {age} years old.");

            //Task 3
            double r;
            const double PI = 3.14;
            Console.WriteLine("Enter the radius of a circle");
            r = Convert.ToDouble(Console.ReadLine());
            double length = 2 * PI * r;
            double area = PI * r * r;
            double volume = 4.0 / 3.0 * PI * r * r * r;
            Console.WriteLine($"Length of a circle = {length:F2}, area = {area:F2} and volume = {volume:F2}");
        }
    }
}
