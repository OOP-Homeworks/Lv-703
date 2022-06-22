//Task 1
Console.WriteLine("Please write lenght of your square");
int? length = System.Convert.ToInt32(Console.ReadLine());

// Інший спосіб - створення окремих змінних int для обчислення площі і периметру, і виведення результату в консоль.
Console.WriteLine($"Square area = {length * length}");
Console.WriteLine($"Square perimeter = {length * 4}");
Thread.Sleep(3000);

//Task 2
Console.WriteLine("\n What is your name?");
string? name = Console.ReadLine();
Console.WriteLine($"How old are you, {name}");
int? age = System.Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"His/Her name is {name} and he/she is {age} years old.");

//Task 3
Console.ReadLine();
Console.WriteLine("Please write radius of your circle");
double r = System.Convert.ToDouble(Console.ReadLine());
double lenght = 2 * Math.PI * r;
double area = Math.PI * r * r;
double volume = 4.0 / 3.0 * Math.PI * r * r * r;
Console.WriteLine($"Lenght={lenght:F2} Area={area:F2} Volume={volume:F2}");