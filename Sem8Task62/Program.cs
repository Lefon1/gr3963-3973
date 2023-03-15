// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int ReadData(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine() ?? "0");
}


int[,] SpiralArr(int n)
{
    int[,] arr = new int[n, n];
    int num = 1; // начальное значение для заполнения
    int rowStart = 0, rowEnd = n - 1; // границы заполнения по строкам
    int colStart = 0, colEnd = n - 1; // границы заполнения по столбцам
    
    while (num <= n * n)
    {
        // заполнение верхней строки слева направо
        for (int i = colStart; i <= colEnd; i++)
        {
            arr[rowStart, i] = num;
            num++;
        }
        rowStart++;

        // заполнение правого столбца сверху вниз
        for (int i = rowStart; i <= rowEnd; i++)
        {
            arr[i, colEnd] = num;
            num++;
        }
        colEnd--;

        // заполнение нижней строки справа налево
        for (int i = colEnd; i >= colStart; i--)
        {
            arr[rowEnd, i] = num;
            num++;
        }
        rowEnd--;

        // заполнение левого столбца снизу вверх
        for (int i = rowEnd; i >= rowStart; i--)
        {
            arr[i, colStart] = num;
            num++;
        }
        colStart++;
    }

    return arr;
}

void PrintArr(int[,] arr)
{
    ConsoleColor[] col = new ConsoleColor[] { ConsoleColor.Green, ConsoleColor.Black };
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.ForegroundColor = col[new Random().Next(0, 2)];
            Console.Write($"{arr[i, j]:D2} "); // Выводим элементы массива через табуляцию
            Console.ResetColor();
        }
        Console.WriteLine(); // Переходим на новую строку после каждой строки массива
    }
}

int rows = ReadData("Введите количество строк: ");
int cols = ReadData("Введите количество столбцов: ");
int[,] arr = SpiralArr(rows);
Console.WriteLine("");
PrintArr(arr);