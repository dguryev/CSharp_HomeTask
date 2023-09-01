/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов случайных целых чисел от 1 до 50 и выводит их на экран.
*/

using System.Runtime.CompilerServices;

int[] GenArray(int minVal, int maxVal, int lenArray)
{
    int[] a = new int[lenArray];
    Random r = new Random();

    for (int i = 0; i < lenArray; i++)
    {
        a[i] = r.Next(minVal, maxVal);
    }

    return a;
}

void PrintArr(int[] a)
{
    Console.Write("[");

    for (int i = 0; i < a.Length - 1; i++)
        Console.Write($" {a[i]},");

    Console.WriteLine($" {a[a.Length - 1]} ]");
}

PrintArr(GenArray(1, 50, 8));


