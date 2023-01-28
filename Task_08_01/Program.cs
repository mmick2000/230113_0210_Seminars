// Task_08_01:
// Напишите программу, которая 
// 1. на вход принимает число (N), 
// 2. на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите целое число:");
int number = Convert.ToInt32(Console.ReadLine());
int startNum = 1;

while (startNum <= number)
{
    if (startNum % 2 == 0)
    {
        Console.Write(startNum);
        if (startNum < number) Console.Write(", ");
    }
    startNum++;
}
