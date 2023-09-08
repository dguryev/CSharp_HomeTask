/*
задача 1 необязательная

на входе целое или вещественное число, надо удалить вторую цифру слева этого числа.

1,45 -> 1,5
1 -> нет
567,123 -> 57,123
*/

Console.WriteLine("Введите число");
double d = Convert.ToDouble(Console.ReadLine());

string s = d.ToString();

if (s.Length < 2)
{
    Console.WriteLine("В числе меньше 2-х цифр");
    return;
}

if (Char.IsDigit(s[1]))
    s = s.Remove(1, 1);
else
    s = s.Remove(2, 1);

Console.WriteLine(s);