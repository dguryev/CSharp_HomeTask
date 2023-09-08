// See https://aka.ms/new-console-template for more information

/*Внутри класса Answer напишите метод IsPalindrome, который принимает на вход пятизначное число number и проверяет, является ли оно палиндромом.

Метод должен проверить является ли число пятизначным, в противном случае - вывести Число не пятизначное и False в следующей строке.

Для остальных чисел вернуть True или False.


14212 -> False
12821 -> True
234322 -> Число не пятизначное
False*/

using System.Xml.Schema;

Answer.Main(new string[] { "14212" });
Answer.Main(new string[] { "12821" });
Answer.Main(new string[] { "234322" });

public class Answer
{
    static bool IsPalindrome(int number)
    {
        // Введите свое решение ниже
        string snum = number.ToString();
        int len = snum.Length;

        if (len != 5)
        {
            Console.WriteLine("Число не пятизначное");
            return false;
        }

        for (int i = 0; i < (len / 2); i++)
        {
            if (snum[i] != snum[len - 1 - i])
                return false;
        }

        return true;

    }

    // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args)
    {
        int number;

        if (args.Length >= 1)
        {
            number = int.Parse(args[0]);
        }
        else
        {
            // Здесь вы можете поменять значения для отправки кода на Выполнение
            number = 64546;
        }

        // Не удаляйте строки ниже
        bool result = IsPalindrome(number);
        System.Console.WriteLine($"{result}");
    }
}
