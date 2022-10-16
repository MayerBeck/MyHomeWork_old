/*

Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22

*/

Console.Write("Input fisrt number: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input second number: ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input third number: ");
int number3 = Convert.ToInt32(Console.ReadLine());

int max;

if(number1 > number2)
    {
    if(number1 > number3) max = number1;
    else max = number2;
    }
else
{
if(number2 > number3) max = number2;
else max = number3;
}
Console.WriteLine($"Большое число из {number1}, {number2} и {number3} это {max}");