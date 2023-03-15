// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка



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

// Функция для нахождения номера строки с минимальной суммой элементов
int MinRowCount(int[,] arr)
{
    int index = -1; 
    int min = int.MaxValue;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum = sum + arr[i, j];
        }
        if(sum<min)
        {
            min=sum;
            index=i;
        }
    }
    return index+1; // Возвращаем номер строки с минимальной суммой элементов
}
int countRow = ReadData("Введите количество строк : ");
int countColum = ReadData("Введите количество столбцов: ");
int min = ReadData("Введите минимальное значение: ");
int max = ReadData("Введите максимальное значение: ");
if (min > max) (min, max) = (max, min);

int[,] mas = Gen2DArr(countRow, countColum, min, max);

Console.WriteLine("Исходный массив:");
Print2DArr(mas);
Console.WriteLine($"Минимальная сумма элементов : строка {MinRowCount(mas)}");