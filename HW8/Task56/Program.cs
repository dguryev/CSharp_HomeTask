/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

using System.ComponentModel.Design;

int[,] CreateArray(int n, int m, int maxValue)
{
    int[,] a = new int[n, m];

    Random r = new Random();

    for (int i = 0; i < a.GetLength(0); i++)
        for (int j = 0; j < a.GetLength(1); j++)
            a[i, j] = r.Next(maxValue);

    return a;
}

void PrintArray(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        Console.Write($"{i}:\t");
        for (int j = 0; j < a.GetLength(1); j++)
            Console.Write($"{a[i, j]}\t");

        Console.WriteLine();
    }

}

int ReadVal(string msgText)
{
    Console.WriteLine(msgText);
    return Convert.ToInt32(Console.ReadLine());
}

int SumOfRow(int[,] a, int row)
{
    int s = 0;

    for (int j = 0; j < a.GetLength(1); j++)
        s += a[row, j];

    return s;
}

int MinRow(int[,] a)
{
    int sMin = SumOfRow(a, 0);
    int iMin = 0;
    int sumRow;

    for (int i = 1; i < a.GetLength(0); i++)
    {
        sumRow = SumOfRow(a, i);

        if (sumRow < sMin)
        {
            sMin = sumRow;
            iMin = i;
        }
    }

    return iMin;

}

int n = ReadVal("Введите количество строк массива");
int m = ReadVal("Введите количество стоблцов массива");
int mv = ReadVal("Введите максимальное значение для генерации элементов");

int[,] a = CreateArray(n, m, mv);
PrintArray(a);
Console.WriteLine();

Console.WriteLine($"Минмальная сумма элементов в {MinRow(a)}-ой строке");