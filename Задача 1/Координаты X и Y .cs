//Напишите программу, которая принимает на вход точки X & Y, причем X не = 0 Y не = 0 и выдает номер четверти плоскости, в которой находится

int[] points = new int[2];
Console.WriteLine("Введите значения X и Y");

for ( int i = 0; i < points.Length; i++ )
{
    points[i] = Convert.ToInt32(Console.ReadLine());
}

if ( points [0] > 0 && points [1] > 0)
{
    Console.WriteLine("Четверть 1");
}
 else if ( points [0] < 0 && points [1] > 0)
{
    Console.WriteLine("Четверть 2");
}
else if ( points [0] < 0 && points [1] < 0)
{
    Console.WriteLine("Четверть 3");
}
 else if ( points [0] > 0 && points [1] < 0)
{
    Console.WriteLine("Четверть 4");
}
else
{
    Console.WriteLine("Вы ввели некорректное значение");
}
