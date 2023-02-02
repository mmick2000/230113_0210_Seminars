// Task_14_01_multiplyNum7&23
// Напишите программу, которая 
// 1. принимает на вход число 
// 2. проверяет, кратно-ли оно одновременно 7 и 23.	С
// 14 -> нет
// 46 -> нет
// 161 -> да

int num1 = 7;
int num2 = 23;


Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

bool MultipleNums(int number)
{
    return number % 7 == 0 & number % 23 == 0;
    // if (number % 7 == 0 & number % 23 == 0)
    // {
    //     return true;
    // }
    // else
    // {
    //     return false; }
}
// int remainderOfDivision = MultipleNums(number);
// int remainderOfDivision = MultipleNums(firstNumber, secondNumber);

// if (remainderOfDivision = true)
if (MultipleNums(number) == true)
{ Console.WriteLine("Да"); }
else { Console.WriteLine("Нет"); }

// bool DivisionNumber(int firstNumber, int secondNumber)
// divisionNumber = DivisionNumber(firstNumber, secondNumber);
// if (divisionNumber == "true")
// Console.WriteLine("Кратно"); //Первое число {firstNumber} кратно второму числу {secondNumber}
// if (divisionNumber == "false") Console.WriteLine($"Не кратно, остаток {firstNumber % secondNumber}"); //
