// Task_13_01_abcde_cOrNull
// Задача 13: Напишите программу, которая 
// 1. выводит третью цифру заданного числа или сообщает, что третьей цифры нет.	
// 645-> 5 
// 78 -> третьей цифры нет 
// 32679 ->6

Console.WriteLine("Введите любое число");
int enterNumber = Convert.ToInt32(Console.ReadLine());
int number = enterNumber;
if (number > -100 && number < 100) {Console.WriteLine($"{number} -> третьей цифры нет");}
else{ while (number < -999 || number > 999){
    number = number /10;}
}
int thirdDigit = /* number - number /100 - */ number %10;
// thirdDigit < 0 ? -thirdDigit : thirdDigit;
Console.WriteLine($"{enterNumber} -> {(thirdDigit < 0 ? -thirdDigit : thirdDigit)}");