// Task_09_01:
// Напишите программу, которая 
// 1. выводит случайное число из отрезка [10, 99] 
// 2. показывает наибольшую цифру числа.
// 78-> 8
// 12-> 2
// 85-> 8

int NumRandomGeneration(int a, int b) // метод генерации числа и его выведения в консоль
{
    int number = new Random().Next(a, b);
    Console.WriteLine($"Берём двузначное число => {number}.");
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
int number = NumRandomGeneration(10, 100);
int maxDigit = MaxDigit(number);
PrintMaxDigit (maxDigit);
// Console.WriteLine($"Наибольшая цифра в нём =>  {maxDigit}.");
number = NumRandomGeneration(20, 70);
maxDigit = MaxDigit(number);
PrintMaxDigit (maxDigit);
// Console.WriteLine($"Наибольшая цифра в нём =>  {maxDigit1}.");
number = NumRandomGeneration(50, 60);
maxDigit = MaxDigit(number);
PrintMaxDigit (maxDigit);
// Console.WriteLine($"Наибольшая цифра в нём =>  {maxDigit2}.");

void PrintMaxDigit (int maxDigit){
    maxDigit = MaxDigit(number);
    Console.WriteLine($"Наибольшая цифра в нём =>  {maxDigit}.");
}

int MaxDigit(int number)
{
    int firstDigit = number / 10;
    int secondDigit = number % 10;
    if (firstDigit > secondDigit) return firstDigit;
    return secondDigit;
}