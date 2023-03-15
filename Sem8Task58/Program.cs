//  Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int ReadData(string mess)
{
    Console.Write(mess);
    return Convert.ToInt32(Console.ReadLine() ?? "0");
}


int[,] Gen2DArr(int Row, int Coloumn, int min, int max)
{
    int[,] arr = new int[Row, Coloumn];
    for (int i = 0; i < Row; i++)
    {
        for (int j = 0; j < Coloumn; j++)
        {
            arr[i, j] = new Random().Next(min, max + 1); // Генерируем случайное значение в заданном диапазоне
        }
    }
    return arr;
}

// Вывод двумерного массива в консоль с случайными цветами для каждого элемента
void Print2DArr(int[,] arr)
{
    ConsoleColor[] col = new ConsoleColor[] { ConsoleColor.Green, ConsoleColor.Black };
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.ForegroundColor = col[new Random().Next(0, 2)];
            Console.Write(arr[i, j] + "\t"); // Выводим элементы массива через табуляцию
            Console.ResetColor();
        }
        Console.WriteLine(); // Переходим на новую строку после каждой строки массива
    }
}

int[,] MatrixXXX(int[,] arr1, int[,] arr2)// Функция вычисления произведения двух матриц
{
    int rows1 = arr1.GetLength(0);
    int columns1 = arr1.GetLength(1);
    int rows2 = arr2.GetLength(0);
    int columns2 = arr2.GetLength(1);

       // Создаем массив для результирующей матрицы
    int[,] result = new int[rows1, columns2];

    // Вычисляем произведение матриц
    for (int i = 0; i < rows1; i++)
    {
        for (int j = 0; j < columns2; j++)
        {
            int sum = 0;
            for (int k = 0; k < columns1; k++)
            {
                sum += arr1[i, k] * arr2[k, j];
            }
            result[i, j] = sum;
        }
    }

    return result;
}

int rows1 = ReadData("Введите количество строк в матрице 1: ");
int columns1 = ReadData("Введите количество столбцов в матрице 1: ");
int min1 = ReadData("Введите минимальное значение для матрицы 1: ");
int max1 = ReadData("Введите максимальное значение для матрицы 1: ");

int rows2 = ReadData("Введите количество строк в матрице 2: ");
int columns2 = ReadData("Введите количество столбцов в матрице 2: ");
int min2 = ReadData("Введите минимальное значение для матрицы 2: ");
int max2 = ReadData("Введите максимальное значение для матрицы 2: ");

int[,] arr1 = Gen2DArr(rows1, columns1, min1, max1);
int[,] arr2 = Gen2DArr(rows2, columns2, min2, max2);
Print2DArr(arr1);
Console.WriteLine();
Print2DArr(arr2);
Console.WriteLine();
Print2DArr(MatrixXXX(arr1, arr2));