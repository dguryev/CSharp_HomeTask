/*
Задача 2 HARD по желанию Напишите программу, которая принимает на вход целое или дробное число и выдаёт количество цифр в числе.
456 -> 3
0 -> 1
89,126 -> 5
0,001->4
*/

Console.WriteLine("Введите число");
double d = Convert.ToDouble(Console.ReadLine());

string s = d.ToString();
int count = 0;

foreach (char c in s)
    if (Char.IsDigit(c)) count++;

Console.WriteLine($"Количество цифр {count}");    
