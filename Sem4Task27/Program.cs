// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

using System.Diagnostics;

        Console.Write("Введите число: ");
        string input = Console.ReadLine()?? "0";

        // Используем цифровой алгоритм
        Stopwatch stopwatch1 = Stopwatch.StartNew();
        int sum1 = 0;
        int number1 = int.Parse(input);
        while (number1 != 0)
        {
            sum1 += number1 % 10;
            number1 /= 10;
        }
        stopwatch1.Stop();

        // Используем строчный алгоритм
        Stopwatch stopwatch2 = Stopwatch.StartNew();
        int sum2 = 0;
        char[] digits = input.ToCharArray();
        foreach (char digit in digits)
        {
            sum2 += int.Parse(digit.ToString());
        }
        stopwatch2.Stop();

        // Выводим результаты
        Console.WriteLine("Сумма цифр в числе (цифровой алгоритм): " + sum1);
        Console.WriteLine("Время выполнения (цифровой алгоритм): " + stopwatch1.Elapsed);
        Console.WriteLine();
        Console.WriteLine("Сумма цифр в числе (строчный алгоритм): " + sum2);
        Console.WriteLine("Время выполнения (строчный алгоритм): " + stopwatch2.Elapsed);