// Task_02: Напишите программу, которая 
// 1. на вход принимает два числа 
// 2. выдаёт, какое число большее, а какое меньшее.

// bool isFinished = false;

Console.WriteLine("Введите первое целое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите воторое целое число");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 > number2){
    Console.WriteLine($"max = {number1}");
} else {
    Console.WriteLine($"max = {number2}");
}
