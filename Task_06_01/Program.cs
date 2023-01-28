// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("Введите целое число:");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 2 == 0){
    Console.WriteLine("Да - введённое число чётное");
} else {
    Console.WriteLine("Нет - введённое число нечётное");
}
