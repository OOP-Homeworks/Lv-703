using System;
using System.Linq;
using System.Collections.Generic;

namespace Homework2
{
    internal class Program
    {
        enum HTTPError
        {
            Error400 = 400,
            Error404 = 404,
            Error504 = 504,
            Error505 = 505
        }
        
        struct Dog
        {
            public string name;
            public string mark;
            public int age;

            public override string ToString()
            {
                return string.Format($"Dog's desciption:\n name - {name},\n mark - {mark},\n age - {age}" );
            }
        }

        static void Main(string[] args)
        {
            //Homework2Part1
            const string IN_THE_RANGE = "in the range [-5;5]";
            const string OUT_OF_THE_RANGE = "out of the range [-5;5]";
            const string VARIABLE_N1 = "\tVariable {0} is " + IN_THE_RANGE; //when the variable is in the range
            const string VARIABLE_N2 = "\tVariable {0} ({1}) is " + OUT_OF_THE_RANGE; //when the variable is out of the range
            Console.Write("Write the first(a) float number : ");
            float a = Convert.ToSingle(Console.ReadLine());
            Console.Write("Write the second(b) float number : ");
            float b = Convert.ToSingle(Console.ReadLine());
            Console.Write("Write the third(c) float number : ");
            float c = Convert.ToSingle(Console.ReadLine());
            bool passedA = a < -5 && a > 5; //passed - is in range
            bool passedB = b < -5 && b > 5;
            bool passedC = c < -5 && c > 5;
            if (passedA && passedB && passedC)
            {
                Console.WriteLine("All numbers are {0}", IN_THE_RANGE);
            }
            else
            {
                Console.WriteLine("Not all numbers are {0}", IN_THE_RANGE);
                Console.WriteLine("  Description : ");
                if (passedA)
                {
                    Console.WriteLine(VARIABLE_N1, nameof(a), a);
                }
                else
                {
                    Console.WriteLine(VARIABLE_N2, nameof(a), a);
                }
                if (passedB)
                {
                    Console.WriteLine(VARIABLE_N1, nameof(b), b);
                }
                else
                {
                    Console.WriteLine(VARIABLE_N2, nameof(b), b);
                }
                if (passedC)
                {
                    Console.WriteLine(VARIABLE_N1, nameof(c), c);
                }
                else
                {
                    Console.WriteLine(VARIABLE_N2, nameof(c), c);
                }
            }



            //Homework2Part2
            Console.WriteLine("\nWrite your 3 integers : ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());
            int number3 = Convert.ToInt32(Console.ReadLine());
            List<int> list = new List<int>();
            list.Add(number1);
            list.Add(number2);
            list.Add(number3);
            Console.WriteLine("\nOutput of max and min values : ");
            int max = list.Max();
            Console.WriteLine("Max value = {0}", max);
            int min = list.Min();
            Console.WriteLine("Min value = {0}", min);

            //Homework2Part3
            Console.Write("\nWrite the error's number : ");
            int error = Convert.ToInt32(Console.ReadLine());
            string describingError = "\nError's description : \n\n";
            switch (error)
            {
                case (int)HTTPError.Error400:
                    Console.WriteLine($"{describingError}400 Bad Request\nThe 400 status code, or Bad Request error, " +
                        "means the HTTP request that was sent to the server has invalid syntax.\n");
                    break;
                case (int)HTTPError.Error404:
                    Console.WriteLine($"{describingError}404 Not Found\nThe 404 status code, or a Not Found error," +
                        " means that the user is able to communicate with the server but it is" +
                        " unable to locate the requested file or resource.\n");
                    break;
                case (int)HTTPError.Error504:
                    Console.WriteLine($"{describingError}504 Gateway Timeout\nThe 504 status code, or Gateway Timeout error," +
                        " means that the server is a gateway or proxy server, and it is not receiving a response " +
                        "from the backend servers within the allowed time period.\n");
                    break;
                case (int)HTTPError.Error505:
                    Console.WriteLine($"{describingError}500 Internal Server Error\nThe 500 status code, or Internal " +
                        "Server Error, means that server cannot process the request for an unknown reason. " +
                        "Sometimes this code will appear when more specific 5xx errors are more appropriate.\n");
                    break;
                default:
                    Console.WriteLine("Error is not found...\n");
                    break;
            }

            //Homework2Part4
            Dog myDog = new Dog();
            Console.WriteLine("Write dog parameters (name, mark, age) : ");
            myDog.name = Console.ReadLine();
            myDog.mark = Console.ReadLine();
            myDog.age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine(myDog);
        }
    }
}
