// Task_11_01_abc_ac
// Напишите программу, которая 
// 1. выводит случайное трёхзначное число
// 2. удаляет вторую цифру этого числа.
// 456 -> 4б|
// 782->72
// 918 -> 98
  
int NumRandomGeneration(int a, int b) // метод генерации числа и его выведения в консоль
{
    int number = new Random().Next(a, b);
    Console.WriteLine($"Получаем случайное трёхзначное число => {number}.");
    return number;
}


int Digit(int number) // метод вычисления результата
{
    int firstDigit = number / 100;
    int secondDigit = number % 10;
    int num = firstDigit * 10 + secondDigit;
    return num;
}

void PrintNumber (int number)
{
int num = Digit(number);
Console.WriteLine(number + " -> " + num);
}

int number = NumRandomGeneration(100, 1000);
// number = NumRandomGeneration(100, 1000);
PrintNumber(number);