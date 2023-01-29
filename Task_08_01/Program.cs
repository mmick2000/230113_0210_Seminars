// Task_08_01:
// Напишите программу, которая 
// 1. на вход принимает число (N), 
// 2. на выходе показывает все чётные числа от 1 до N.

int isFinished = 0;
Console.WriteLine("Введите целое число больше нуля:");
while (isFinished == 0)
{
    int N = Convert.ToInt32(Console.ReadLine());
    if (N == 1){
        Console.WriteLine ("Хоть единица и натуральное число, но чётных чисел от нуля до него нет. Введите другое число");
       isFinished = 0; 
    }
    else if (N > 1)
    {
        int startNum = 1;
        while (startNum <= N)
        {
            if (startNum % 2 == 0)
            {
                Console.Write(startNum);
                if (startNum < N - 1)
                {
                    Console.Write(", ");
                    isFinished = 1;
                }
            }
            startNum++;
        }
    }
    else
    {
        Console.WriteLine("Внимательнее читай задание... и если введено 1, соответственно, тогда снова вводи число");
        isFinished = 0;
    }
}
