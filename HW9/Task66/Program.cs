/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int ReadVal(string msgText)
{
    Console.WriteLine(msgText);
    return Convert.ToInt32(Console.ReadLine());
}

int SumN(int m, int n)
{
    if (n == m)
        return m;

    return n + SumN(m, n - 1);
}

int m = ReadVal("Введите число M");
int n = ReadVal("Введите число N");

Console.WriteLine($"M = {m}; N = {n} -> {SumN(m, n)}");