/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.*/

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);
    return array;
} 

int SumOddElements(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
        if (i % 2 != 0)
        {
            sum += array[i];
        }
    return sum;    
}
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine();
}
Console.WriteLine("Input a numbers of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a min possible value:"); 
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a max possible value:");
int max = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandomArray(size, min, max);
ShowArray(myArray);
Console.WriteLine(SumOddElements(myArray));