/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

int ReadVal(string msgText)
{
    Console.WriteLine(msgText);
    return Convert.ToInt32(Console.ReadLine());
}

int Akk(int m, int n)
{
    if (m == 0) 
        return n + 1;

    if (n == 0) 
        return Akk(m - 1, 1);

    return Akk(m - 1, Akk(m, n - 1));
}

int m = ReadVal("Введите число M");
int n = ReadVal("Введите число N");

Console.WriteLine($"m = {m}, n = {n} -> A(m, n) = {Akk(m, n)}");