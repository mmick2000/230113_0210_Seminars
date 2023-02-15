// Task_23_01_cubeOfNumber
// Задача 23: Напишите программу, которая 
// 1. принимает на вход число (N) 
// 2. выдаёт таблицу кубов чисел от 1 до N.
// 3->1, 8,27
// 5 -> 1, 8, 27, 64,125

Console.WriteLine("Введите число больше нуля:");
int.TryParse(Console.ReadLine(), out int number);
if (number < 1)
{
    Console.WriteLine("Некорректный ввод.");
    return;
}

CubeOfNumber(number);

void CubeOfNumber(int n)
{
    Console.Write($"{number} -> ");
    int count = 1;
    while (count <= n)
    {
        Console.Write(Math.Pow(count, 3));
        if (count < n) Console.Write(", ");
        count++;
    }
}

