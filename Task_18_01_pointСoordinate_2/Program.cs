// Task_18_01_pointСoordinate_2
// Задача 18: Напишите программу, которая 
// по заданному номеру четверти, показывает 
// диапазон возможных координат 
// точек в этой четверти (х и у).
// 2 | 1
// ----->
// 3 | 4
//   V 


Console.WriteLine("Введите номер четверти");
// int quarterN = Convert.ToInt32(Console.ReadLine());
string quarterN = Console.ReadLine();

string rangeOfNumber = RangeOfNumber(quarterN);

Console.WriteLine(rangeOfNumber);

string RangeOfNumber(string numberOfQuarter)
{
    // if (quarterN == 1) return "x > 0 и y > 0";
    // if (quarterN == 2) return "x < 0 и y > 0";
    // if (quarterN == 3) return "x < 0 и y < 0";
    // if (quarterN == 4) return "x > 0 и y < 0";
    // return ("Нет такой четерти");
    switch (quarterN)
    {
        case "1": return "x > 0 и y > 0";
        /* break; */
        case "2": return "x < 0 и y > 0";
        /* break; */
        case "3": return "x < 0 и y < 0";
        /* break; */
        case "4": return "x > 0 и y < 0";
        /* break; */
        default: return ("Нет такой четерти");
    }
}