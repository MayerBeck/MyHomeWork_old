/*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии. */


int RecursMetod(int N)
{
    if (N == 0) return 0;
    Console.Write(N + " ");
    return RecursMetod(N - 1);
}
Console.Write("Введите число:");
int N = int.Parse(Console.ReadLine()!);

RecursMetod(N);