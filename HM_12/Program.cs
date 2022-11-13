/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.*/

int sum = 0;

while(true)
{
    Console.WriteLine("Введите целое число:");

    if(int.TryParse(Console.ReadLine(), out int number))
    {
        Console.WriteLine("Сумма всех цифр числа " + number + " равна " + Calculate(number));
        break;
    }
    else Console.WriteLine("Некорректно указано число!\n");
}

int Calculate(int number)
{
    string str = Math.Abs(number).ToString();
    for(int i = 0; i < str.Length; i++)
    {
        int.TryParse(str[i].ToString(), out int num);
        sum += num;
    }
    return sum;
}