/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

int ReadVal(string msgText)
{
    Console.WriteLine(msgText);
    return Convert.ToInt32(Console.ReadLine());
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

int[,] CreateArray(int n)
{
    int[,] a = new int[n, n];
    int sVal = 1;

    int countSycle = a.GetLength(0) / 2 + a.GetLength(0) % 2;

    for (int i = 0; i<=countSycle; i++)
        sVal = FillBorder(a, i, sVal);
   
   return a;
}

int FillBorder(int[,] a, int index, int startVal)
{
    int n = a.GetLength(0) - index;
    for (int i = index; i < n; i++)
        a[index, i] = startVal++;

    for (int i = (index + 1); i < n; i++)
        a[i, n - 1] = startVal++;

    for (int i = n - 2; i >= index; i--)
        a[n - 1, i] = startVal++;

    for (int i = n - 2; i >= index + 1; i--)
        a[i, index] = startVal++;

    return startVal;
}

int n = ReadVal("Введите количество элементов");
Console.WriteLine();
PrintArray(CreateArray(n));
Console.WriteLine();


