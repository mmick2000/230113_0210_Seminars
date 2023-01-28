
// Task_04_01: Напишите программу, которая 
// 1. принимает на вход три числа 
// 2. выдаёт максимальное из этих чисел.

Console.WriteLine("Введите первое целое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите воторое целое число");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье целое число");
int number3 = Convert.ToInt32(Console.ReadLine());
int max = number1;
if (number2 > max) max = number2;
if (number3 > max) max = number3;
Console.WriteLine(max);