// Task_09_01:
// Напишите программу, которая 
// 1. выводит случайное число из отрезка [10, 99] 
// 2. показывает наибольшую цифру числа.
// 78-> 8
// 12-> 2
// 85-> 8

int NumRandom(int a, int b) // метод генерации числа и его выведения в консоль
{
    int number = new Random().Next(a, b);
    Console.WriteLine($"Случайное число из отрека 1-99 => {number}.");
    return number;
}
// int firstDigit = number / 10;
// int secondDigit = number % 10;
// if (firstDigit > secondDigit)
// {
//     Console.WriteLine($"Наибольшая цифра в нём =>  {firstDigit}.");
// }
// else
// {
//     Console.WriteLine($"Наибольшая цифра в нём =>  {secondDigit}.");
// }
// NumRandom(10, 100);
int number = NumRandom(1, 100);
int maxDigit = MaxDigit(number);
Console.WriteLine($"Наибольшая цифра в нём =>  {maxDigit}.");
number = NumRandom(1, 100);
int maxDigit1 = MaxDigit(number);
Console.WriteLine($"Наибольшая цифра в нём =>  {maxDigit1}.");
number = NumRandom(1, 100);
int maxDigit2 = MaxDigit(number);
Console.WriteLine($"Наибольшая цифра в нём =>  {maxDigit2}.");

int MaxDigit(int number)
{
    int firstDigit = number / 10;
    int secondDigit = number % 10;
    if (firstDigit > secondDigit) return firstDigit;
    else return secondDigit;
}