// Task_19_01_palindrom_abc_cba
// Задача 19: Напишите программу, которая 
// 1. принимает на вход пятизначное число 
// 2. проверяет, является ли оно палиндромом.
// 14212 -> нет 
// 23432 -> да 
// 12821-> да



Console.WriteLine("Введите пятизначное число:");
int.TryParse(Console.ReadLine(), out int number);  
if (number < 10000 || number > 99999) {
    Console.WriteLine("Некорректный ввод");
    return;
}
int reverseNum = ReverseNum(number);
Ask (reverseNum, number);

string Ask(int a, int b){
if (reverseNum == number)
return "Да";
else return "Нет";
}
Console.WriteLine(number + " -> " + Ask (reverseNum, number));

int ReverseNum(int num)
{
    int result = 0;
    while (num > 0)
    {
        result = result * 10 + num % 10;
        num /= 10;
    }
        return result;
}