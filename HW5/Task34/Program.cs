/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

int[] CreateArray(int n, int min, int max)
{
    int[] array = new int[n];
    Random r = new Random();

    for (int i = 0; i < array.Length; i++)
        array[i] = r.Next(min, max);

    return array;
}

void PrintArray(int[] array)
{
    Console.Write($"[{array[0]}");

    for (int i = 1; i < array.Length; i++)
        Console.Write($", {array[i]}");

    Console.Write($"]");
}

int CountEven(int[] array)
{
    int count=0;

    foreach(int item in array)
        if (item % 2 == 0)
            count++;

    return count;
}

int ArraySize = 4, min = 100, max = 1000;

int [] array = CreateArray(ArraySize, min, max);
PrintArray(array);

int countEven = CountEven(array);

Console.WriteLine($" -> {countEven}");
