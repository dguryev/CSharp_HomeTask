/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

int Pow(int a, int b)
{
    int p = a;
    for (int i = 2; i <= b; i++)
        p *= a;

    return p;
}

Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ведите степень");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Результат {Pow(a, b)}");