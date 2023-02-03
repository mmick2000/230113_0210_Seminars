// Task_15_01_day67_weekend
// Задача 15: 
// Напишите программу, которая 
// 1. принимает на вход цифру, обозначающую день недели, и
// 2. проверяет, является ли этот день выходным.	
// 6	-> да 
// 7	-> да 
// 1 -> нет

bool isFinished = false;
Console.WriteLine("Введите цифру, обозначающую день недели? для определения, выходной-ли это день");
while (isFinished == false)
{
    int number = Convert.ToInt32(Console.ReadLine());
    FindDay(number);
}
void FindDay(int number)
{
    if (number >= 1 && number <= 7)
    {
        bool weekDay = FindWeekend(number);
        string day = weekDay ? "Да" : "Нет";
        Console.WriteLine(day);
        isFinished = true;
    }
    else
    {
        Console.WriteLine($"{number} находится за пределами диапазона дней недели - введите цифру от 1-го до 7-ми");
        isFinished = false;
    }
}
    bool FindWeekend(int number)
    {
        return number == 6 || number == 7;
    }