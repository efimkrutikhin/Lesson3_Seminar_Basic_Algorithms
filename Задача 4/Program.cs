//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве
// A (3,6); B(2,1) -> 5,09
// A (7,-5); B(1,-1) -> 7,21

// Console.WriteLine("Введите координаты двух точек: ");

// Console.WriteLine("x1: ");
// int x1 = int.Parse(Console.ReadLine());
// Console.WriteLine("y1: ");
// int y1 = int.Parse(Console.ReadLine());
// Console.WriteLine("x2: ");
// int x2 = int.Parse(Console.ReadLine());
// Console.WriteLine("y2: ");
// int y2 = int.Parse(Console.ReadLine());

// double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
// Console.WriteLine("Расстояние двух точек A({0},{1}),B({2},{3}) = {4}", x1,y1,x2,y2,distance);

Console.WriteLine("Введите координаты точек A и B: ");

Console.Write("x1: ");
int x1 = int.Parse(Console.ReadLine());
Console.Write("y1: ");
int y1 = int.Parse(Console.ReadLine());
Console.Write("x2: ");
int x2 = int.Parse(Console.ReadLine());
Console.Write("y2: ");
int y2 = int.Parse(Console.ReadLine());

double distance = Math.Sqrt(Math.Pow(x2 - x1,2) + Math.Pow(y2 - y1,2));

Console.WriteLine("Расстояние двух точек A({0},{1}),B({2},{3}) = {4}", x1,y1,x2,y2,distance);
