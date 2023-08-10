/*
Задача 7 HARD по желанию - идет за 2 обязательных Напишите программу, которая принимает на вход целое число любой разрядности и на выходе показывает третью цифру слева этого числа или говорит, что такой цифры нет. Через строку решать нельзя.
456111 -> 6
78 -> нет
9146548 -> 4
3 -> нет
*/

Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
int countDigits = 0;
int searchDig = 3;

int temp = a;

while (temp > 0)
{
    countDigits++;
    temp = temp / 10;
}

if (countDigits < searchDig)
{
    Console.WriteLine($"В числе меньше {searchDig} цифр");
    return;
}

temp = (a / ((int) Math.Pow(10, countDigits - searchDig )) ) % 10;

Console.WriteLine($"{searchDig} цифра слева это {temp}");



