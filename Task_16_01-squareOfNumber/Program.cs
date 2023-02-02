// Task_16_01
// Напишите программу, которая 
// 1. принимает на вход два числа 
// 2. проверяет, является ли одно число квадратом другого.	С
// 5, 25 -> да
// -4,16 -> да
// 25, 5 -> да
// 12 мин
// 8,9 -> нет

Console.WriteLine("Введите два числа, подтверждая ввод через Enter");
int firstNumber = Convert.ToInt32(Console.ReadLine());
int secondNumber = Convert.ToInt32(Console.ReadLine());

bool MultipleNums(int num1, int num2)
{
if (num1 % num2 == 0 || num2 % num1 == 0)
    {
        return true;
    }
    else
    {
        return false; }  
}

bool result = MultipleNums(firstNumber, secondNumber);
if (result)
{ Console.WriteLine("Да"); }
else { Console.WriteLine($"Нет"); }
