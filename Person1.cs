using System;
using System.Collections.Generic;
using System.Text;

namespace Homework4
{
    internal class Person
    {
        private string name;
        private DateTime birthYear;
        public string Name
        {
            get { return name; }
        }
        public DateTime BirthYear
        {
            get { return birthYear; }
        }
        Person()
        {
            birthYear = DateTime.MinValue;
            name = "No Name";
        }
        Person(string name, DateTime birthYear)
        {
            this.name = name;
            this.birthYear = birthYear;
        }
        public int Age()
        {
            return DateTime.Now.Year - this.birthYear.Year;
        }
        public static Person Input()
        {
            Console.Write("Enter the name of person: ");
            string name = Console.ReadLine();
            Console.Write("Enter the date of birthday: ");
            DateTime birthYear = Convert.ToDateTime(Console.ReadLine());
            Person person = new Person(name, birthYear);
            return person;
        }
        public void ChangeName(string name)
        {
            this.name = name;
        }
        public override string ToString()
        {
            return String.Format($"Information: {name}, {Age()} years old.");
        }
        public void Output()
        {
            Console.WriteLine(ToString());
        }
        public static bool operator ==(Person A, Person B)
        {
            return A.Name == B.Name;
        }
        public static bool operator !=(Person A, Person B)
        {
            return !(A == B);
        }
        public override int GetHashCode()
        {
            return 0;
        }
        public override bool Equals(object o)
        {
            return true;
        }

    }
}
