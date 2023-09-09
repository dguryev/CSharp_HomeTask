/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/

using System.Data;
using System.Diagnostics.CodeAnalysis;

int CountNum(string msg)
{
    Console.WriteLine(msg);

    return Convert.ToInt32(Console.ReadLine());
}

int[] ArrayNum(string msg, int n)
{
    Console.WriteLine(msg);

    int[] array = new int[n];

    for (int i = 0; i < n; i++)
        array[i] = Convert.ToInt32(Console.ReadLine());

    return array;

}

int CountGT(int [] array) => array.Count(i => i > 0 );

void PrintArray(int[] array) => Console.Write(string.Join(" ", array));

int n = CountNum("Введите колчичество чисел");
int[] array = ArrayNum("Введите числа", n);

PrintArray(array);

Console.WriteLine($" -> {CountGT(array)}");
