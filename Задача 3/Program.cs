//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел
//От 1 до N
//5 -> 1,4,9,16,25
//2 -> 1,4
Console.WriteLine("Введите числовое значение");
int second = Convert.ToInt32(Console.ReadLine());
int first = 1;

if( second <= 0){
    Console.WriteLine("Только положительное значение");
}
else{
    while( first <= second){
    int res = first * first;
    Console.WriteLine(res);
    first++;}
}
    

