// Task_03. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 1. принимает на вход номер дня недели.
// 2. выводит в консоль день недели или что номер не подходит.
// 3. или вывести сообщение, что такого дня в неделе не сущестуе.
//    3 -> Среда
//    5 -> Пятница


Console.WriteLine("Введите номер дня недели");
int numberOfDay = Convert.ToInt32(Console.ReadLine());
switch (numberOfDay)
{
case 1: Console.WriteLine("Понедельник"); 
break;
case 2: Console.WriteLine("Вторник");
break;
case 3: Console.WriteLine("Среда");
break;
case 4: Console.WriteLine("Четверг");
break;
case 5: Console.WriteLine("Пятница");
break;
case 6: Console.WriteLine("Суббота");
break;
case 7: Console.WriteLine("Воскресение");
break;
default: Console.WriteLine("Такого дня в неделе не существует"); 
break;
}