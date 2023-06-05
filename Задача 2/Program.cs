//Напишите программу, которая по заданному номеру четверти, показывает диапазоны возможных координат точек в этой плоскости (X и Y);
Console.WriteLine("Введите номер четверти");
int num = Convert.ToInt32(Console.ReadLine());

if( num == 1){
    Console.WriteLine("X > 0, Y > 0");
}
else if( num == 2){
    Console.WriteLine("X < 0, Y > 0");
}
else if( num == 3){
    Console.WriteLine("X < 0, Y < 0");
}
else if( num == 4){
    Console.WriteLine("X > 0, Y < 0");
}
