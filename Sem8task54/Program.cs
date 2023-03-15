// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// Функция для чтения данных с консоли
int ReadData(string mess)
{
    Console.Write(mess);
    return Convert.ToInt32(Console.ReadLine() ?? "0");
}

// Генерация двумерного массива заданного размера со значениями в заданном диапазоне
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

// Сортировка каждой строки двумерного массива по убыванию
void Sort2DArr(int[,] arr)
{
    int[] row = new int[arr.GetLength(1)]; // Создаем временный массив для хранения одной строки двумерного массива
    for (var i = 0; i < arr.GetLength(0); i++)
    {
        for (var j = 0; j < arr.GetLength(1); j++)
        {
            row[j] = arr[i, j]; // Копируем одну строку двумерного массива во временный массив
        }
        int[] sortedRow = SortBuble(row); // Сортируем временный массив методом пузырьковой сортировки

        for (var k = 0; k < arr.GetLength(1); k++)
        {
            arr[i, k] = sortedRow[k]; // Копируем отсортированную строку из временного массива обратно в двумерный массив
        }
    }
}

// Реализация пузырьковой сортировки одномерного массива по убыванию
int[] SortBuble(int[] arr)
{
    int[] result = arr; // создаем копию исходного массива
    int arrlen = result.Length; // сохраняем длину массива в переменную
    int buf = result[0]; // временная переменная для обмена элементами
    for (int j = 0; j < arrlen; j++) // внешний цикл, который проходит по всем элементам массива
    {
        for (int i = 0; i < arrlen - 1 - j; i++) // внутренний цикл, который проходит по неотсортированным элементам массива
        {
            if (result[i] < result[i + 1]) // если текущий элемент меньше следующего, то меняем их местами
            {
                buf = result[i + 1];
                result[i + 1] = result[i];
                result[i] = buf;
            }
        }
    }
    return result; // возвращаем отсортированный массив
}

int countRow = ReadData("Введите количество строк : ");
int countColum = ReadData("Введите количество столбцов : ");
int min = ReadData("Введите минимальное значение: ");
int max = ReadData("Введите максимальное значение: ");

int[,] mas = Gen2DArr(countRow, countColum, min, max);

Console.WriteLine("Исходный:");
Print2DArr(mas);

Sort2DArr(mas);

Console.WriteLine("Отсортированный:");
Print2DArr(mas);