﻿// Console.Clear();
//                 Console.Write("Введите первое число: ");
//                 int number1 = Convert.ToInt32(Console.ReadLine());
//                 Console.Write("Введите второе число: ");
//                 int number2 = Convert.ToInt32(Console.ReadLine());

//                 int number = Math.Abs(number1);

//                 for (int i = 0; i < number; i++)
//                 {
//                     Console.Write($"Остаток от деления {i} на {number2} = {i% number2}\n");
//                 }

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // Напишите программу, которая на вход принимает число и выдаёт, 
        // является ли число чётным (делится ли оно на два без остатка).

        // Console.Clear();
        // Console.Write("Введите первое число: ");
        // int num = Convert.ToInt32(Console.ReadLine());

        // switch (num % 2)
        // {
        //     case 0:
        //         Console.WriteLine($"Число: {num} - четное");
        //         break;
        //     case 1:
        //         Console.WriteLine($"Число: {num} - нечётное");
        //         break;
        // }

///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

// Напишите программу, которая на вход принимает число и выдаёт, 
 // является ли число чётным (делится ли оно на два без остатка).

        Console.Clear();
        Console.Write("Введите первое число: ");
        int num = Convert.ToInt32(Console.ReadLine());

        switch (num % 2)
        {
            case 0:
                Console.WriteLine($"Число: {num} - четное");
                break;
            case 1:
                Console.WriteLine($"Число: {num} - нечётное");
                break;
        }
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////