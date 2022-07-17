using System;
using System.Collections.Generic;
using System.IO;

namespace Homework8
{
    internal class HW8
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();
            Console.WriteLine("Enter the information about 10 different shapes:");
            const int LENGHT = 10;
            while(shapes.Count < LENGHT)
            {
                try
                {
                    Console.WriteLine("Write the name and side of the Shape[{0}].", shapes.Count + 1);
                    Console.WriteLine("Add to the beginning of name letter 'S' for square or 'C' for circle.");
                    string name = Console.ReadLine();
                    double side = Convert.ToDouble(Console.ReadLine());
                    if (side <= 0)
                        throw new ApplicationException("The lenght of side can't be less than 0");
                    if (name.StartsWith('S'))
                    {
                        Square square = new Square(name, side);
                        shapes.Add(square);
                    }
                    else if (name.StartsWith('C'))
                    {
                        Circle circle = new Circle(name, side);
                        shapes.Add(circle);
                    }
                    else
                        throw new ApplicationException("Enter correct name of the shape!");
                }
                catch (FormatException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
                catch (ApplicationException e)
                {
                    Console.WriteLine($"Error: {e.Message}");
                }

            }
            Console.WriteLine("\n\nThe list of shapes");
            foreach (Shape shape in shapes)
                shape.Print();
            
            var maxPerimetr = shapes[0].Perimetr();
            var maxName = shapes[0].Name;
            for (int i = 1; i < shapes.Count; i++)
            {
                if (shapes[i].Perimetr() > maxPerimetr)
                {
                    maxPerimetr = shapes[i].Perimetr();
                    maxName = shapes[i].Name;
                }
            }
            Console.WriteLine("The {0} shape has the largest perimetr.", maxName);
            shapes.Sort();
            Console.WriteLine("The sorted list:");
            foreach (Shape shape in shapes)
            {
                shape.Print();
            }
        }
    }
}
