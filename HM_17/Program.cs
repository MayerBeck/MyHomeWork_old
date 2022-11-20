/*Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.*/

int PositiveDigit(int m)
{
    int count =0;
    int num;
    for (int dig=0; dig <m; dig++)
    {
        Console.Write("Введите число: ");
        num = Convert.ToInt32(Console.ReadLine());
        if(num > 0)
        count++;
    }
    return count;
}
Console.Write("Сколько чисел: ");

int m = Convert.ToInt32(Console.ReadLine());

Console.Write(PositiveDigit(m));