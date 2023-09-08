/*

Напишите программу для. проверки истинности утверждения ¬(X ⋁ Y ⋁ Z) = ¬X ⋀ ¬Y ⋀ ¬Z (Теорема Де Моргана) . 
Но теперь количество предикатов не три, а генерируется случайным образом от 5 до 25, сами значения предикатов случайные, 
проверяем это утверждение 100 раз, выводим на экран , сколько времени отработала программа. 
В конце вывести результат проверки истинности этого утверждения.

*/

using System.Diagnostics;

int countPredicats = new Random().Next(5, 26);
int countCheck = 100;
Stopwatch sw=new Stopwatch();

sw.Start();
Console.Write($"| N\t|");
for (int j = 0; j < countPredicats; j++)
    Console.Write($" P{j + 1}\t|");

Console.Write(" Res1\t| Res2\t| Итог\t|");

Console.WriteLine();

for (int i = 0; i < countCheck; i++)
{
    Console.Write($"| {i + 1}\t|");

    bool val1 = (new Random().Next(2) == 0 ? false : true);
    bool val2 = !val1;

    Console.Write($" {val1}\t|");

    for (int j = 1; j < countPredicats; j++)
    {
        bool pr = (new Random().Next(2) == 0 ? false : true);
        Console.Write($" {pr}\t|");
        val1 = val1 || pr;
        val2 = val2 && !pr;
    }

    val1 = !val1;
    Console.Write($" {val1}\t| {val2}\t|");
    Console.Write($" {val1 == val2}\t|");

    Console.WriteLine();        
}

sw.Stop();

Console.WriteLine($"Время работы {sw.ElapsedMilliseconds} мс");