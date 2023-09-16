/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

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

void SortString(int[,] a, int row)
{
    for (int i = 0; i < a.GetLength(1); i++)
        for (int j = 0; j < a.GetLength(1) - 1 - i; j++)
            if (a[row, j] < a[row, j + 1])
                (a[row, j], a[row, j + 1]) = (a[row, j + 1], a[row, j]);
}

void SortArray(int[,] a)
{
    for (int i=0; i<a.GetLength(0); i++) 
        SortString(a, i);
}

int n = ReadVal("Введите количество строк массива");
int m = ReadVal("Введите количество стоблцов массива");
int mv = ReadVal("Введите максимальное значение для генерации элементов");

int[,] a = CreateArray(n, m, mv);
PrintArray(a);
Console.WriteLine();

Console.WriteLine("Отсортированный массив");
SortArray(a);
PrintArray(a);
