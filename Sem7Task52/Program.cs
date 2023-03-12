// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4


Console.Clear();

//Принимаем из консоли число
int ReadData(string mess)
{
    Console.Write(mess);
    return Convert.ToInt32(Console.ReadLine() ?? "0");
}

//Генерируем массив случайными числами
int[,] Gen2DArr(int row, int colum, int bottom, int top)
{
    Random rnd = new Random();
    int[,] arr = new int[row, colum];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < colum; j++)
        {
            arr[i, j] = rnd.Next(bottom, top);
        }
    }
    return arr;
}

//Вывод двумерного массива на экран 
void Print2DArr(int[,] arr)
{
     for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

//Поиск среднее арифметического элемента в каждом столбце 
double[] ColMean2DArr(int[,] arr)
{
    double[] res = new double[arr.GetLength(1)];
    
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            res[j] = res[j] + arr[i, j];
        }
         res[j] = Math.Round(res[j]/ arr.GetLength(0),5);
    }

    return res;
}

//Вывод массива 1мерного массива
// void Print1DArr(double[] arr)
// {

//     for (int i = 0; i < arr.Length - 1; i++)
//     {
//         Console.Write($"{arr[i]};\t");
//     }
//     Console.Write($"{arr[arr.Length - 1]}.");
// }
void Print1DArr(double[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i].ToString("F1")};\t");
    }
    Console.Write($"{arr[arr.Length - 1].ToString("F1")}.");
}

int Row = ReadData("Введите количество строк : ");
int Coloumn= ReadData("Введите количество столбцов : ");
int min = ReadData("Введите 1 границу : ");
int max = ReadData("Введите 2 границу : ");
if (min > max) (min, max) = (max, min);

int[,] mas = Gen2DArr(Row, Coloumn, min, max);
Print2DArr(mas);
Console.WriteLine();
Print1DArr(ColMean2DArr(mas));