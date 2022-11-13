/* Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.*/

int[] CreateArray(int size)
{ 
    int[] array = new int[size];
    Console.Write("Введите массив ");

    for(int i = 0; i < size; i++)
        array[i] = Convert.ToInt32(Console.ReadLine());
    return array;
}
 void SetArray(int[] array)
 {
    for (int i =0; i < array.Length; i++)
        Console.Write(array[i] + " ");
 }

Console.Write("Введите размер элементов: ");
int m = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateArray(m);
SetArray(myArray);