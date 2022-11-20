/*Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.*/

Console.WriteLine();
Console.Write("Введите b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine();
Console.Write("Введите k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine();
Console.Write("Введите b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine();
Console.Write("Введите k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine();

LinearEqations(k1, k2, b1, b2);

void LinearEqations(double m, double n, double a, double b)
{
double x = 0;
double y = 0;    
    if (m == n) Console.WriteLine("Уравнение не имеет решений!");
    else
    {
        x = (b - a) / (m - n);
        y = m*x + a;
    }
    Console.WriteLine($"Решение уравнения (x, y): ({x}, {y})");
    Console.WriteLine();
}