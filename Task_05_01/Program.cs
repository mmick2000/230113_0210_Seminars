// 5. Напишите программу, которая 
// 1. на вход принимает одно число (N), 
// 2. на выходе показывает все целые числа в промежутке от -N до N.
// 4-> "-4,-3,-2,-1, 0,1, 2,3,4"
// 2-> "-2,-1, 0,1,2"

Console.WriteLine("Введите любое целое число от нуля и больше");
int N = Convert.ToInt32(Console.ReadLine());
int number = 0 - N;
while (number <= N){
    Console.Write(number);
    number ++;
    if (number <= N){
    Console.Write(", ");}
}