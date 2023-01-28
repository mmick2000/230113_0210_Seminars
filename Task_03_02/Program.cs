// Task_03_02. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 1. принимает на вход номер дня недели.
// 2. выводит в консоль день недели или что номер не подходит.
// 3. или вывести сообщение, что такого дня в неделе не сущестуе.
//    3 -> Среда
//    5 -> Пятница


Console.WriteLine("Введите номер дня недели");
string numberOfDay = Console.ReadLine();
if (numberOfDay == "1")
{
Console.WriteLine("Понедельник"); 
}
else if (numberOfDay == "2")
{
Console.WriteLine("Вторник"); 
}
else if (numberOfDay == "3")
{
Console.WriteLine("Среда"); 
}
else if (numberOfDay == "4")
{
Console.WriteLine("Четверг"); 
}
else if (numberOfDay == "5")
{
Console.WriteLine("Пятница"); 
}
else if (numberOfDay == "6")
{
Console.WriteLine("Суббота"); 
}
else if (numberOfDay == "7")
{
Console.WriteLine("Воскресение"); 
}
else 
{
Console.WriteLine("Такого дня в неделе не существует"); 
}
