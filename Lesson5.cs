using System;
using System.Collections.Generic;
namespace Homework5
{
    internal class Lesson5
    {
        static void Main(string[] args)
        {
            // Task 5.1
            List<IFlyable> flyables = new List<IFlyable>();
            flyables.Add(new Plane("Boeing", 12345));
            flyables.Add(new Plane("Airbus", 1000));
            flyables.Add(new Bird("parrot", true));
            flyables.Add(new Bird("ostrich", false));
            foreach (IFlyable flyable in flyables)
                flyable.Fly();

            // Task 5.2
            Console.WriteLine();
            List<int> myColl = new List<int>();
            const int LENGHTOFLIST = 10;
            for (int i = 0; i < LENGHTOFLIST; i++)
            { 
                Console.Write($"Enter the number[{i+1}] to add to the list: ");
                myColl.Add(Convert.ToInt32(Console.ReadLine()));
            }
            for (int i = 0; i < myColl.Count; i++)
            {
                if (myColl[i] == -10)
                {
                    Console.WriteLine($"The number -10 is at {i + 1} position.");
                }
            }
            for (int i = 0; i < myColl.Count; i++)
            {
                if (myColl[i] > 20)
                {
                    myColl.Remove(myColl[i]);
                    i--;
                }
            }
            Console.WriteLine("\nPrinting new collection...");
            for (int i = 0; i < myColl.Count; i++)
            {
                Console.WriteLine($"Element [{i+1}]: {myColl[i]}");
            }
            myColl.Insert(2, 1);
            myColl.Insert(8, -3);
            myColl.Insert(5, -4);
            myColl.Sort();
            Console.WriteLine("\nPrinting new sorted collection...");
            for (int i = 0; i < myColl.Count; i++)
            {
                Console.WriteLine($"Element [{i + 1}]: {myColl[i]}");
            }

            // Homework
            // Task 5.1
            // Create array or list of IDeveloper.
            // Add some Programmers and Builders to it.
            // Call Create() and Destroy() methods for all of it
            // Implement interface IComparable for clases and sort array or list of IDeveloper

            List<IDeveloper> developers = new List<IDeveloper>();
            developers.Add(new Programmer("C++"));
            developers.Add(new Programmer("Java"));
            developers.Add(new Builder("Hammer"));
            developers.Add(new Builder("Saw"));
            developers.Add(new Programmer("Solidity"));
            developers.Add(new Programmer("Python"));
            foreach (var developer in developers)
            {
                developer.Create();
                developer.Destroy();
            }
            Console.WriteLine("\nPrinting list of developers:");
            foreach (var developer in developers)
                Console.WriteLine(developer);
            Console.WriteLine("\nPrinting sorted list of developers:");
            developers.Sort(); // sorting list of IDeveloper
            foreach (var developer in developers)
                Console.WriteLine(developer);

            // Task 5.2
            // In the Main() method declare Dictionary<uint, string>.
            // Add to Dictionary from Console 7 pairs(ID, Name) of some persons.
            // Ask user to enter ID, then find and write corresponding Name from your Dictionary.
            // If you can't find this ID - say about it to user. 

            Dictionary<uint, string> users = new Dictionary<uint, string>();
            users.Add(10001, "Taras");
            users.Add(10002, "Roland");
            users.Add(10003, "LeBron");
            users.Add(10004, "Jonatan");
            users.Add(10005, "Julia");
            users.Add(10006, "Oliver");
            
            while (true)
            {
                Console.Write("\nEnter the ID of the user to find his name: ");
                uint key = Convert.ToUInt32(Console.ReadLine());
                if (users.ContainsKey(key))
                {
                    Console.WriteLine($"ID: {key} --> User: {users[key]}");
                    break;
                }
                else
                    Console.WriteLine("You've entered incorrect ID!");
            }
        }
    }
}
