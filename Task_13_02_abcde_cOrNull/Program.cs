// Task_13_02_abcde_cOrNull
// Задача 13: Напишите программу, которая 
// 1. выводит третью цифру заданного числа или сообщает, что третьей цифры нет.	
// 645-> 5 
// 78 -> третьей цифры нет 
// 32679 ->6

Console.WriteLine("Введите любое число");

int FindThirdDigit(int number)
{
    while (number < -999 || number > 999)
    {
        number = number / 10;
    }
    int thirdDigit = /* number - number /100 - */ number % 10;
    return thirdDigit;
}

int enterNumber = Convert.ToInt32(Console.ReadLine());
int number = enterNumber;


if (number > -100 && number < 100) { Console.WriteLine($"{number} -> третьей цифры нет"); }
else
{
    int thirdDigit = FindThirdDigit(number);
    Console.WriteLine($"{enterNumber} -> {(thirdDigit < 0 ? -thirdDigit : thirdDigit)}");
}
    // thirdDigit < 0 ? -thirdDigit : thirdDigit;