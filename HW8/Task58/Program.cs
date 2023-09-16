/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

int[,] CreateArray(int n, int maxValue)
{
    int[,] a = new int[n, n];

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

int [,] MultiMatrix(int [,] a, int [,] b)
{
    int n = a.GetLength(0);
    int [,] c = new int[n, n];

    for (int i=0; i<n; i++)
        for (int j=0; j<n; j++)
            c[i, j] = MultiElement(a, b, i, j);

    return c;
}

int MultiElement(int [,] a, int [,] b, int row, int col)
{
    int s = 0;

    for (int i=0; i<a.GetLength(0); i++)
        s+=a[row, i]*b[i, col];

    return s;
}

int n=ReadVal("Введите размерность матрицы");
int mv = ReadVal("Введите максимальное значение для генерации элементов");

int [,] a = CreateArray(n, mv);
int [,] b = CreateArray(n, mv);

Console.WriteLine("Матрица A");
PrintArray(a);
Console.WriteLine();

Console.WriteLine("Матрица B");
PrintArray(b);
Console.WriteLine();

Console.WriteLine("Матрица A*B");
PrintArray(MultiMatrix(a, b));



