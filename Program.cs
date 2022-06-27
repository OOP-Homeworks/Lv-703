//HomeWork2
//Task1

Console.Write("float a = ");
float a = Convert.ToSingle(Console.ReadLine());
Console.Write("float b = ");
float b = Convert.ToSingle(Console.ReadLine());
Console.Write("float c = ");
float c = Convert.ToSingle(Console.ReadLine());
if ((a >= -5 && b >= -5 && c >= -5) && (a <= 5 && b <= 5 && c <= 5))
{
    Console.WriteLine("All your values are in range of -5 to 5");
}
else
{
    Console.WriteLine("one or more of your vales are not in the range of -5 to 5");
}
Thread.Sleep(2500);

//Task2

Console.Write("speed of car 1 = ");
int speed1 = Convert.ToInt32(Console.ReadLine());
Console.Write("speed of car 2 = ");
int speed2 = Convert.ToInt32(Console.ReadLine());
Console.Write("speed of car 3 = ");
int speed3 = Convert.ToInt32(Console.ReadLine());
int max = (speed1 > speed2 && speed1 > speed3) ? speed1 : (speed2 > speed1 && speed2 > speed3) ? speed2 : speed3;
int min = (speed1 < speed2 && speed1 < speed3) ? speed1 : (speed2 < speed1 && speed2 < speed3) ? speed2 : speed3;
Console.WriteLine($"max speed = {max}");
Console.WriteLine($"min speed = {min}");

//Task 3 
Console.WriteLine("enter the number of your Error from the following: 400,401,402");
int e = Convert.ToInt32(Console.ReadLine());
Console.WriteLine((ErrorCode)e);


//Task 4

Dog dog = new Dog();
dog.Name = "Patron";
dog.Mark = "Jack Russell";
dog.Age = 7;
Console.WriteLine(dog);
public struct Dog
{
    public string Name;
    public string Mark;
    public int Age;

    public override string ToString()
    {
        return $"My name is {Name} my mark is {Mark} and my age is {Age}";
    }
}

public enum ErrorCode { Bad_Request = 400, Unauthorized, Payment_Required };