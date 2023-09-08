/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

int sumNum(int a)
{
    int s = 0;

    while (a > 0)
    {
        s += a % 10;
        a /= 10;
    }

    return s;
}

Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма цифр в числе {sumNum(a)}");