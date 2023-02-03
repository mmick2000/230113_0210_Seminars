// Task_08_01:
// Напишите программу, которая 
// 1. на вход принимает число (nu), 
// 2. на выходе показывает все чётные числа от 1 до nu.


int isFinished = 0;
Console.WriteLine("Введите целое число больше нуля:");
while (isFinished == 0)
{
    int num = Convert.ToInt32(Console.ReadLine());
    if (num == 1){
        Console.WriteLine ("Хоть единица и натуральное число, но чётных чисел от нуля до него нет. Введите другое число");
       isFinished = 0; 
    }
    else if (num > 1)
    {
        int startNum = 1;
        while (startNum <= num
)
        {
            if (startNum % 2 == 0)
            {
                Console.Write(startNum);
                if (startNum < num
         - 1)
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
        Console.WriteLine("Внимательнее читай задание... и снова вводи число");
        isFinished = 0;
    }
}
