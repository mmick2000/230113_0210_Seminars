// Task_12_01_EvenOddNum
// >>> Напишите программу, которая 
// 1. будет принимать на
// вход два числа
// 2. выводить, является ли первое число кратным второму. 
// 2. Если число 1 не кратно числу 2, то
// программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

// void GetNumber(int firstNumber, int secondNumber)
// {
Console.WriteLine("Введите два числа, подтверждая ввод через Enter");
int firstNumber = Convert.ToInt32(Console.ReadLine());
int secondNumber = Convert.ToInt32(Console.ReadLine());
// return firstNumber;
// return secondNumber;
// }
// GetNumber(firstNumber, secondNumber);

int MultipleNums(int num1, int num2)
{
    return num1 % num2;
}
int remainderOfDivision = MultipleNums(firstNumber, secondNumber);

if (remainderOfDivision == 0)
    {Console.WriteLine("Кратно");}
else {Console.WriteLine($"Не кратно, остаток {remainderOfDivision}");}

// bool DivisionNumber(int firstNumber, int secondNumber)
// divisionNumber = DivisionNumber(firstNumber, secondNumber);
// if (divisionNumber == "true")
// Console.WriteLine("Кратно"); //Первое число {firstNumber} кратно второму числу {secondNumber}
// if (divisionNumber == "false") Console.WriteLine($"Не кратно, остаток {firstNumber % secondNumber}"); //
