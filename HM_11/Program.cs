/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B*/

int numA = 0;
int numB = 0;
int sum = 0;

while(true)
{
    Console.WriteLine("Введите целое число А:");
    if(int.TryParse(Console.ReadLine(), out int number))
    {
        numA = number; break;
    }
    else Console.WriteLine("Некорректно указано число!\n");
}

while(true)
{
    Console.WriteLine("Введите целое число В:");

    if(int.TryParse(Console.ReadLine(), out int number))
    {
        if(number < 0) 
        {
            Console.WriteLine("Введено отрицательное число!");
            continue;
        }
        else numB = number; break;
    }
    else Console.WriteLine("Некорректно указано число!\n");
}

Console.WriteLine("число " + numA + " в степени " + numB + " = " + Calculate(numA, numB));


int Calculate(int a, int b)
{
    if (a == 0 && b == 0)
    {
        sum = 1;
    }
    else
    {
        sum = a;
        for(int i = 1; i < b; i++)
        {
            sum = sum * a;
        }
    }
    return sum;
}