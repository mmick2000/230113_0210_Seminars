// Task_21_01_distance3D_xyz
// Задача 21: Напишите программу, которая 
// 1. принимает на вход координаты двух точек 
// 2. находит расстояние между ними в 3D пространстве.
// А (3,6,8); В (2,1,-7), -> 15.84
// А (7,-5, 0); В (1,-1,9) -> 11.53


Console.WriteLine("Введите координаты точки A");
Console.WriteLine("AX:");
int.TryParse(Console.ReadLine(), out int ax);
Console.WriteLine("AY:");
int.TryParse(Console.ReadLine(), out int ay);
Console.WriteLine("AZ:");
int.TryParse(Console.ReadLine(), out int az);
Console.WriteLine("Введите координаты точки B");
Console.WriteLine("BX:");
int.TryParse(Console.ReadLine(), out int bx);
Console.WriteLine("BY:");
int.TryParse(Console.ReadLine(), out int by);
Console.WriteLine("BZ:");
int.TryParse(Console.ReadLine(), out int bz);
double distanceBetweenPoints = DistanceBetweenPoints(ax, ay, az, bx, by, bz);
Console.WriteLine(Math.Round(distanceBetweenPoints, 2, MidpointRounding.ToZero));

double DistanceBetweenPoints(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double distance2D = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2));
    return Math.Sqrt(Math.Pow(distance2D, 2) + Math.Pow((z1 - z2), 2));
     
}