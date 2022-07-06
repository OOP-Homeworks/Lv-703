using System;
using System.Collections.Generic;
using System.Text;

namespace Homework5
{
    internal class Programmer : IDeveloper
    {
        string language;
        public string Tool 
        { 
            get
            { 
                return language;
            } 
            set
            { 
                this.language = value;
            }
        }
        public Programmer(string language)
        {
            this.language = language;
        }
        public void Destroy()
        {
            Console.WriteLine($"Programmer has destroyed class in {language}...");
        }
        public void Create()
        {
            Console.WriteLine($"Programmer has created something using {language}...");
        }
        int IComparable<IDeveloper>.CompareTo(IDeveloper other)
        {
            return String.Compare(this.Tool, other.Tool);
        }
        public override string ToString()
        {
            return String.Format($"This programmer writes code on {language}.");
        }
    }
}
