// Task_06_01:
// Напишите программу, которая 
// 1. на вход принимает число 
// 2. выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Введите целое число:");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 2 == 0){
    Console.WriteLine("Да - введённое число чётное");
} else {
    Console.WriteLine("Нет - введённое число нечётное");
}
