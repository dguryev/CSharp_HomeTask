/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/


int[] CreateArray(int n, int min, int max)
{
    int[] array = new int[n];
    Random r = new Random();

    for (int i = 0; i < array.Length; i++)
        array[i] = r.Next(min, max);

    return array;
}

void PrintArray(int[] array)
{
    Console.Write($"[{array[0]}");

    for (int i = 1; i < array.Length; i++)
        Console.Write($", {array[i]}");

    Console.Write($"]");
}

int SumNonEvenElemnet(int[] array)
{
    int sum = 0;

    for (int i = 0; i < array.Length; i++)
        if (i % 2 != 0)
            sum += array[i];

    return sum;

}

int ArraySize = 4, min = -100, max = 101;

int[] array = CreateArray(ArraySize, min, max);
PrintArray(array);

int sumNonEven = SumNonEvenElemnet(array);

Console.WriteLine($" -> {sumNonEven}");
