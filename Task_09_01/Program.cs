// Task_09_01:
// Напишите программу, которая 
// 1. выводит случайное число из отрезка [10, 99] 
// 2. показывает наибольшую цифру числа.
// 78-> 8
// 12-> 2
// 85-> 8


int number = new Random().Next(10, 99);
Console.WriteLine(number);
int a1 = number / 10;
int a2 = number % 10;
if (a1 > a2)
{
    Console.WriteLine(a1);
}else{
    Console.WriteLine(a2);
}