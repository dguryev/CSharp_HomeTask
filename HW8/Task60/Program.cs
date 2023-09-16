/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

int ReadVal(string msgText)
{
    Console.WriteLine(msgText);
    return Convert.ToInt32(Console.ReadLine());
}

int [,,] CreateArray(int n)
{
    int [,,] a = new int [n, n, n];

    Random r = new Random();

    for (int i = 0; i<a.GetLength(0); i++)
        for (int j =0; j<a.GetLength(1); j++)
            for (int k=0; k<a.GetLength(2); k++)
            {
                int value;
                do
                {
                    value = r.Next(10, 100);        
                } while(isConsist(a, value));

                a[i, j, k] = value;
            }

    return a;
}

bool isConsist(int [,,] a, int value)
{
    foreach(int i in a)
        if (i == value)
            return true;

    return false;
}

void PrintArray(int [,,] a)
{
   for (int i = 0; i<a.GetLength(0); i++)
   {
        for (int j =0; j<a.GetLength(1); j++)
            for (int k=0; k<a.GetLength(2); k++)
                Console.Write($"{a[i,j,k]}({i},{j},{k})\t");

        Console.WriteLine(); 
   }
}

int n = ReadVal("Введите количество элементов");
Console.WriteLine();
PrintArray(CreateArray(n));
