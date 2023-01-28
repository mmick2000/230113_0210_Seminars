// 5. Напишите программу, которая 
// 1. на вход принимает одно число (N), 
// 2. на выходе показывает все целые числа в промежутке от -N до N.
// 4-> "-4,-3,-2,-1, 0,1, 2,3,4"
// 2-> "-2,-1, 0,1,2"

bool isFinished = false;
Console.WriteLine("Введите любое целое число больше нуля:");
while (isFinished == false)
{
    int N = Convert.ToInt32(Console.ReadLine());
    if (N > 0)
    {
        // do{
        int number = 0 - N;

        while (number <= N)
        {
            Console.Write(number);
            number++;
            if (number <= N)
            {
                Console.Write(", ");
                isFinished = true;
            }
        }
    }
    else
    {
        Console.WriteLine("Внимательнее читай задание... и снова вводи число");
        isFinished = false;
    }
}

// } while (N <= 0);
