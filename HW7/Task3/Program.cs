/*
Внутри класса Answer напишите методы CreateIncreasingMatrix, PrintArray, PrintListAvr и FindAverageInColumns.

Метод CreateIncreasingMatrix должен создавать матрицу заданной размерности, 
с каждым новым элементом увеличивающимся на опрделенное число. 
Метод принимает на вход три числа (n - количество строк матрицы, m - количество столбцов матрицы, 
k - число, на которое увеличивается каждый новый элемент) и возвращает матрицу, удовлетворяющую этим условиям.

Метод PrintArray должен выводить на экран сгенерированную методом CreateIncreasingMatrix матрицу.

Метод FindAverageInColumns принимает целочисленную матрицу типа int[,] и возвращает одномерный массив типа double. 
Этот метод вычисляет среднее значение чисел в каждом столбце матрицы и сохраняет результаты в виде списка.

Метод PrintListAvr принимает одномерный массив, возвращенный методом FindAverageInColumns 
и выводит этот список на экран в формате "The averages in columns are: x.x0 x.x0 x.x0 ...", 
где x.x0 - это значения средних значений столбцов, округленные до двух знаков после запятой, разделенные знаком табуляции.

n = 3;
m = 4;
k = 2;


1   3   5   7   
9   11  13  15  
17  19  21  23  
The averages in columns are: 
9.00    11.00   13.00   15.00

*/

using System;
using System.Globalization;

Answer.Main(new string[] { "4", "5", "3" });

public class Answer
{
    public static void PrintArray(int[,] matrix)
    {
        // Введите свое решение ниже
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
                Console.Write($"{matrix[i, j]}\t");

            Console.WriteLine();
        }

    }

    public static int[,] CreateIncreasingMatrix(int n, int m, int k)
    {
        // Введите свое решение ниже
        int[,] a = new int[n, m];

        for (int i = 0; i < a.GetLength(0); i++)
            for (int j = 0; j < a.GetLength(1); j++)
                a[i, j] = 1 + (i * a.GetLength(1) + j) * k;

        return a;
    }

    static void PrintListAvr(double[] list)
    {
        // Введите свое решение ниже
        
        Console.WriteLine($"The averages in columns are: "); 

        foreach(double d in list)
            Console.Write($"{Math.Round(d, 2):f2}\t");
    }

    static double[] FindAverageInColumns(int[,] matrix)
    {
        // Введите свое решение ниже
        double sumColumn;
        double[] avg = new double[matrix.GetLength(1)];

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sumColumn = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
                sumColumn += matrix[i, j];

            avg[j] = sumColumn / matrix.GetLength(0);
        }

        return avg;
    }


    // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args)
    {
        int n, m, k;

        if (args.Length >= 3)
        {
            n = int.Parse(args[0]);
            m = int.Parse(args[1]);
            k = int.Parse(args[2]);
        }
        else
        {
            // Здесь вы можете поменять значения для отправки кода на Выполнение
            n = 3;
            m = 4;
            k = 2;
        }

        // Не удаляйте строки ниже
        int[,] result = CreateIncreasingMatrix(n, m, k);
        PrintArray(result);
        PrintListAvr(FindAverageInColumns(result));
    }
}