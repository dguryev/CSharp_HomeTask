/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

int count = 3;
int max = 0;

for (int i = 0; i < count; i++)
{
    Console.WriteLine($"Веведите {i + 1}-ое число.");
    int a = Convert.ToInt32(Console.ReadLine());

    if (i == 0)
        max = a;
    else if (a > max)
        max = a;
}

Console.WriteLine($"Максимальное число: {max}");
