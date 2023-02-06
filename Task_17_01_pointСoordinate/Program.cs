// Task_17_01_pointСoordinate
// 17. Напишите программу, которая 
// 1. принимает на вход координаты точки (X и Y), 
// 2. причём Х != 0 и У != 0  => Х ≠ 0 и У ≠ 0
// 3. выдаёт номер четверти плоскости, в которой находится эта точка.
// 2 | 1
// ----->
// 3 | 4
//   V 


Console.WriteLine("Введите координаты точки");
Console.WriteLine("X:");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Y:");
int y = Convert.ToInt32(Console.ReadLine());

int quarter = Quarter(x, y);
string result = quarter > 0?
$"Указанные координаты соответствуют {quarter}-й четверти."
: "Введены не корректные координаты. Требуются числа, отличные от нуля. Начните, пожалуйста, заново.";
Console.WriteLine(result);

int Quarter(int xc, int yc)
{
if(xc > 0 && yc > 0) return 1;
if(xc < 0 && yc > 0) return 2;
if(xc < 0 && yc < 0) return 3;
if(xc > 0 && yc < 0) return 4;
return 0;
}



