// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
// *Заполнить числами Фиббоначи и выделить цветом найденную цифру


Console.Clear();//очищение консоли

// Создаем двумерный массив и заполняем его числами Фибоначчи
int[,] arr = Gen2DArr(8, 8);

// Выводим массив на экран
Console.WriteLine("Массив:");
Print2DArr(arr);

// Запрашиваем у пользователя данные
int row = ReadData("Введите номер строки: ");
int column = ReadData("Введите номер столбца: ");

if (row >= 0 && row < arr.GetLength(0) && column >= 0 && column < arr.GetLength(1))// Проверяем, есть ли элемент с такими координатами в массиве
{
    int num = arr[row, column];
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"Значение элемента: {num}");
    Console.ResetColor();
}
else
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"Такого элемента в массиве нет.");// Если элемента нет, выводим сообщение об ошибке
    Console.ResetColor();
}

int ReadData(string line)// Функция для чтения целочисленных данных с консоли
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}


int[,] Gen2DArr(int rows, int columns)// Метод для создания и заполнения двумерного массива числами Фибоначчи
{
    int[,] arr = new int[rows, columns];
    arr[0, 0] = 1;
    arr[0, 1] = 1;
    for (int i = 2; i < columns; i++)
    {
        arr[0, i] = arr[0, i - 1] + arr[0, i - 2];
    }
    for (int i = 1; i < rows; i++)
    {
        for (int j = 1; j < columns; j++)
        {
            arr[i, j] = arr[i - 1, j] + arr[i, j - 1];
        }
    }
    return arr;
}

void Print2DArr(int[,] arr)// печать массива цветного и ровного
{
    ConsoleColor[] col = new ConsoleColor[]
    {ConsoleColor.Black, ConsoleColor.Blue, ConsoleColor.Cyan,
    ConsoleColor.DarkBlue, ConsoleColor.DarkCyan, ConsoleColor.DarkGray,
    ConsoleColor.DarkGreen, ConsoleColor.DarkMagenta, ConsoleColor.DarkRed,
    ConsoleColor.DarkYellow, ConsoleColor.Gray, ConsoleColor.Green,
    ConsoleColor.Magenta, ConsoleColor.Red, ConsoleColor.White,ConsoleColor.Yellow};


    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.ForegroundColor = col[new Random().Next(0, 16)];
            Console.Write("{0,5}", arr[i, j]);
            Console.ResetColor();
        }
        Console.WriteLine();
    }
}
