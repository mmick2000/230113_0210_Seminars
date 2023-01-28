// 0. Демонстрация решения
// Напишите программу, которая 
// 1. на вход принимает число 
// 2. выдаёт его квадрат.
// вывод результата в консоль.
// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49

Console.WriteLine("Введите любое целое число, которое необходимо возвести в квадрат");
int number = Convert.ToInt32(Console.ReadLine());
int square  = number * number;

Console.WriteLine("Квадрат числа " + number + " равно " + square);
Console.WriteLine($"Квадрат числа {number} равно {square}");
