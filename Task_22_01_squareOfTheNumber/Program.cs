// Task_22_01_squareOfTheNumber
// Задача 22: Напишите программу, которая 
// 1. принимает на вход число (N) 
// 2. выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 3, 16, 25.
// 2 -> 1,4

Console.WriteLine ("Введите число больше нуля");
// int number = Convert.ToInt32(Console.ReadLine());
int.TryParse(Console.ReadLine(), out int number);
if(number < 1) {
    Console.WriteLine ("Введите число в соответствии с условием");
    return;
}
// int n = 1;
/* else */ QuadOfNumber(number);
void QuadOfNumber(int n)
{
Console.Write(number + " -> ");
    int count =  1;
    while(count <= n)
    {
        Console.Write($"{count*count/* ,3 */}");
       if (count < n) Console.Write(", ");
        count++;
    }
}