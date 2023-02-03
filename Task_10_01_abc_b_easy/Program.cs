// Task_10_01_abc_b
// Задача 10: Напишите программу, которая 
// 1. принимает на вход трёхзначное число и 
// 2. на выходе показывает вторую цифру этого числа.	
// 456->5 
// 782 -> 8 
// 918 ->1


bool isFinished = false;
Console.WriteLine("Введите трёхзначное число");
while (isFinished == false)
{
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99 && number < 1000)
{
    int secondDigit = (number - (number % 10) - (number / 100 * 100))/10;
    Console.WriteLine($"{number} -> {secondDigit}");
    isFinished = true;
}
else
{
    Console.WriteLine("Внимательнее читай условие - снова попытайтесь ввести трёхзначное число");
    isFinished = false;
}
}
// Console.WriteLine($"{number} -> {secondDigit}");



// Console.WriteLine("Генерируется трёхзначное число");
// int NumRandomGeneration(int a, int b){
// int randomNum = new Random().Next(a, b);
// Console.WriteLine($"Получаем случайное трёхзначное число => {randomNumber}.");
//     return randomNumber;
// }

// int number = Convert.ToInt32(Console.ReadLine());