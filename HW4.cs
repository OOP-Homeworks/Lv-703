using System;

namespace Homework4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] people = new Person[6];

            for (int i = 0; i < people.Length; i++)
            {
                people[i] = Person.Input();
            }
           foreach(Person person in people)
            {
                person.Output();
                if (person.Age() < 16)
                {
                    person.ChangeName("Very Young");
                }
            }
            Console.WriteLine("The information about all people:");
            for (int i = 0; i < people.Length; i++)
            {
                people[i].Output();
            }
            Console.WriteLine("The information about people who have at least 1 other person with the same name:");
            for(int i = 0; i < people.Length; i++)
            {
                for(int j = 0; j < people.Length; j++)
                {
                    if (people[i] == people[j] && i != j && people[i].Name != "Very Young")
                    {
                        people[j].Output();
                    }
                }
            }
        }
    }
}
