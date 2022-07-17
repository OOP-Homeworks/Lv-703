using System;
using System.Collections.Generic;
using System.Text;

namespace Homework8
{
    internal abstract class Shape : IComparable
    {
        private string name;
        public string Name
        {
            get { return name; }
        }
        public Shape(string name)
        {
            this.name = name;
        }
        public abstract double Area();
        public abstract double Perimetr();
        public abstract void Print();
        public int CompareTo(object obj)
        {
            Shape other = obj as Shape;
            if (other == null) 
                return 0; 
            else 
                return this.Area().CompareTo(other.Area());
        }
    }
}
