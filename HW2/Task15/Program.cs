/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

Console.WriteLine("Введите номер дня недели");
int d = Convert.ToInt32(Console.ReadLine());

if (d < 1 || d > 7)
{
    Console.WriteLine("Номер дня неправильный");
    return;
}

if (d == 6 || d == 7)
    Console.WriteLine("Да");
else
    Console.WriteLine("Нет");
