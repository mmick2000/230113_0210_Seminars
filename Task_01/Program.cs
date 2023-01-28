// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// 01. Напишите программу, которая 
// 1. на вход принимает два
// числа,
// 2.  второе чоисло возводит в квадрат,
// 3. проверяет, является-ли первое число квадратом
// второго.
// а = 25, b = 5 -> да 
// а = 2, b = 10 -> нет 
// а = 9, b = -3 -> да 
// а = -3 b = 9 -> нет

Console.WriteLine("Введите первое целое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите воторое целое число");
int number2 = Convert.ToInt32(Console.ReadLine());
int square  = number2 * number2;
if (square == number1){
    Console.WriteLine($"Первое число {number1} равно квадрату второго числа {number2}");
} else {
    Console.WriteLine($"Первое число {number1} не равно квадрату второго числа {number2}");
}
