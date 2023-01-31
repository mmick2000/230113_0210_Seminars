// Task_11_01_abc_ac
// Напишите программу, которая 
// 1. выводит случайное трёхзначное число
// 2. удаляет вторую цифру этого числа.
// 456 -> 4б|
// 782->72
// 918 -> 98
  
int NumRandomGeneration(int a, int b) // метод генерации числа и его выведения в консоль
{
    int randomNumber = new Random().Next(a, b);
    Console.WriteLine($"Получаем случайное трёхзначное число => {randomNumber}.");
    return randomNumber;
}

int GetNumber(int randomNumber) // метод вычисления результата
{
    int firstDigit = randomNumber / 100;
    int secondDigit = randomNumber % 10;
    int num = firstDigit * 10 + secondDigit;
    return num;
}

void PrintNumber (int randomNumber)
{
int num = GetNumber(randomNumber);
Console.WriteLine(randomNumber + " -> " + num);
}

int randomNumber = NumRandomGeneration(100, 1000);
// Console.WriteLine($"Получаем случайное трёхзначное число => {randomNumber}.");
PrintNumber(randomNumber);