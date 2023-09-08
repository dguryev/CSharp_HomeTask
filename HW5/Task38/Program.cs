/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76*/

using Microsoft.VisualBasic;

double[] CreateArray(int n, int min, int max)
{
    double[] array = new double[n];
    Random r = new Random();

    for (int i = 0; i < array.Length; i++)
        array[i] = r.NextDouble() * Math.Pow(10, r.Next(min, max));

    return array;
}

void PrintArray(double[] array)
{
    Console.Write($"[{array[0]:f2}");

    for (int i = 1; i < array.Length; i++)
        Console.Write($", {array[i]:f2}");

    Console.Write($"]");
}

double minElem(double[] array)
{
    double min = array[0];

    for (int i = 1; i < array.Length; i++)
        if (array[i] < min)
            min = array[i];

    return min;
}

double maxElem(double[] array)
{
    double max = array[0];

    for (int i = 1; i < array.Length; i++)
        if (array[i] > max)
            max = array[i];

    return max;
}

int ArraySize = 5, min = 0, max = 4;

double[] array = CreateArray(ArraySize, min, max);
PrintArray(array);

double minEl = minElem(array);
double maxEl = maxElem(array);
double dist = maxEl - minEl;

Console.WriteLine($" => {maxEl:f2} - {minEl:f2} = {dist:f2}");
