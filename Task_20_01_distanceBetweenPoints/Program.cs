// Task_20_01_distanceBetweenPoints
// Задача 20: Напишите программу, которая
// 1. принимает на вход координаты двух точек 
// 2. находит расстояние между ними в 2D пространстве.
// А (3,6); В (2,1) -> 5,09
// А (7,-5); В (1,-1) -> 7,21

Console.WriteLine("Введите координаты точки A");
Console.WriteLine("AX:");
/* int ax =  */
int.TryParse(Console.ReadLine(), out int ax);
Console.WriteLine("AY:");
/* int ay =  */
int.TryParse(Console.ReadLine(), out int ay);
Console.WriteLine("Введите координаты точки B");
Console.WriteLine("BX:");
/* int bx =  */
int.TryParse(Console.ReadLine(), out int bx);
Console.WriteLine("BY:");
/* int by =  */
int.TryParse(Console.ReadLine(), out int by);
// Console.WriteLine("Введите координаты точки A");
// Console.WriteLine("AX:");
// int ax = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("AY:");
// int ay = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координаты точки B");
// Console.WriteLine("BX:");
// int bx = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("BY:");
// int by = Convert.ToInt32(Console.ReadLine());

// int i = int.Parse(Console.ReadLine());
// if (int.TryParse(Console.ReadLine(), out int i))


double distanceBetweenPoints = DistanceBetweenPoints(ax, ay, bx, by);
Console.WriteLine(Math.Round(distanceBetweenPoints, 2, MidpointRounding.ToZero));

double DistanceBetweenPoints(int x1, int y1, int x2, int y2)
{
    return Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2));
     
}


// Console.WriteLine(ax);
// Console.WriteLine(ay);
// Console.WriteLine(bx);
// Console.WriteLine(by);