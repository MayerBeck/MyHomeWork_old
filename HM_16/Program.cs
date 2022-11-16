/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.*/

double[] CreateRandomDoubleArray(int size, int minValue, int maxValue )
{
    double[] array = new double[size];
    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1) + new Random().NextDouble();
    return array;
}
 void ShowArray(double[] array)
 {
    Console.Write("Array is: ");
    for (int i =0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine("  \n"); 
 }    
double DifferentMaxMinArray(double[] array)
{
    double dif = 0;
    double min= array[0];
    double max = array[0];
    for (int i = 0; i< array.Length; i++)
    {
        if (array[i]< array[0])
        {
            min = array[i];
        }
        if (array[i] > array[0])
        {
            max = array[i];
        }
        dif = max - min;
        dif = Math.Round(dif);
    }
    return dif;
}
Console.WriteLine("Input a numbers of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a min possible value:"); 
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a max possible value:");
int max = Convert.ToInt32(Console.ReadLine());
double[] myArray = CreateRandomDoubleArray(size, min, max);
ShowArray(myArray);
Console.WriteLine(DifferentMaxMinArray(myArray));