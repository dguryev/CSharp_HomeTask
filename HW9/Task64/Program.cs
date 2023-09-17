/*
Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

int ReadVal(string msgText)
{
    Console.WriteLine(msgText);
    return Convert.ToInt32(Console.ReadLine());
}

string PrintN(int n, int curr)
{
    if (n == curr)
        return n.ToString();

    return $"{curr}\t{PrintN(n, curr + 1)}";
}

int n = ReadVal("Введите число N");

Console.Write($"N = {n} ->\t{PrintN(n, 1)}");
Console.WriteLine();


