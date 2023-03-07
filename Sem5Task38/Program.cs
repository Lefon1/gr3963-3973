// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
// Отсортируйте массив методом вставки


// Функция для чтения данных из консоли
int ReadData(string mess)
{
    Console.Write(mess);
    return Convert.ToInt32(Console.ReadLine() ?? "0");
}

// Функция для генерации массива случайных чисел
double[] Gen1DArrRandom(int len, int bottom, int top)
{
    // Создаем объект класса Random для генерации случайных чисел
    Random rnd = new Random();
    double[] arr = new double[len];

    // Заполняем массив случайными числами в заданном диапазоне
    for (int i = 0; i < len; i++)
    {
        arr[i] = Math.Round(rnd.Next(bottom, top) + rnd.NextDouble(), 3);
    }

    // Возвращаем сгенерированный массив
    return arr;
}

// Функция для вывода массива на экран в одну строку
void Print1DArrLine(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"({arr[i]})\t");
    }
    Console.WriteLine($"({arr[arr.Length - 1]})]");
}

// Функция для поиска разницы между максимальным и минимальным элементами массива
(double, double, double) SearchDiffMaxMin(double[] arr)
{
    double min = double.MaxValue;
    double max = double.MinValue;
    // Ищем минимальный и максимальный элементы массива
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
        if (arr[i] < min) min = arr[i];
    }

    // Вычисляем разницу между максимальным и минимальным элементами и возвращаем кортеж из трех значений
    return (max - min, min, max);
}

// Считываем данные из консоли: длина массива, нижняя и верхняя границы последовательности
int length = ReadData("Введите длину массива: ");
int min = ReadData("Введите 1 границу последовательности: ");
int max = ReadData("Введите 2 границу последовательности: ");

double[] mas = new double[] { };
// Создаем массив случайных чисел с помощью функции Gen1DArrRandom
if (min < max) mas = Gen1DArrRandom(length, min, max);
else mas = Gen1DArrRandom(length, max, min);

// Выводим массив на экран в одну строку с помощью функции Print1DArrLine
Print1DArrLine(mas);

// Вычисляем разницу между максимальным и минимальным элементами массива с помощью функции SearchDiffMaxMin
(double, double, double) res = SearchDiffMaxMin(mas);

// Выводим результат на экран
Console.WriteLine($"\nМинимальное число = {res.Item2} " +
                  $"\nМаксимальное число = {res.Item3}" +
                  $"\nРазница между числами = {res.Item1}");



































/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

//Сделал запрос у chatgpt на улучшение кода, код не за

/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////




// using System;

// namespace RandomArray
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int length = ReadInputInt("Введите длину массива: ");
//             int min = ReadInputInt("Введите 1 границу последовательности: ");
//             int max = ReadInputInt("Введите 2 границу последовательности: ");

//             if (min >= max)
//             {
//                 int temp = min;
//                 min = max;
//                 max = temp;
//             }

//             double[] arr = GenerateRandomArray(length, min, max);

//             Console.WriteLine("Сгенерированный массив:");
//             PrintArray(arr);

//             (double diff, double minVal, double maxVal) = FindMinMaxDifference(arr);
//             Console.WriteLine($"Минимальное число: {minVal}");
//             Console.WriteLine($"Максимальное число: {maxVal}");
//             Console.WriteLine($"Разница между числами: {diff}");
//         }

//         static int ReadInputInt(string message)
//         {
//             int result;
//             bool success = false;

//             while (!success)
//             {
//                 Console.Write(message);
//                 success = int.TryParse(Console.ReadLine(), out result);

//                 if (!success)
//                 {
//                     Console.WriteLine("Ошибка ввода! Попробуйте еще раз.");
//                 }
//             }

//             return result;
//         }

//         static double[] GenerateRandomArray(int length, int min, int max)
//         {
//             Random rnd = new Random();
//             double[] arr = new double[length];

//             for (int i = 0; i < length; i++)
//             {
//                 arr[i] = Math.Round(rnd.Next(min, max) + rnd.NextDouble(), 3);
//             }

//             return arr;
//         }

//         static void PrintArray(double[] arr, int decimalPlaces = 3)
//         {
//             Console.Write("[");
//             for (int i = 0; i < arr.Length - 1; i++)
//             {
//                 Console.Write($"{arr[i].ToString($"F{decimalPlaces}")}, ");
//             }
//             Console.WriteLine($"{arr[arr.Length - 1].ToString($"F{decimalPlaces}")}]");
//         }

//         static (double diff, double minVal, double maxVal) FindMinMaxDifference<T>(T[] arr) where T : IComparable<T>
//         {
//             T min = arr[0];
//             T max = arr[0];

//             for (int i = 1; i < arr.Length; i++)
//             {
//                 if (arr[i].CompareTo(min) < 0)
//                 {
//                     min = arr[i];
//                 }
//                 else if (arr[i].CompareTo(max) > 0)
//                 {
//                     max = arr[i];
//                 }
//             }

//             double diff = Convert.ToDouble(max) - Convert.ToDouble(min);
//             return (diff, Convert.ToDouble(min), Convert.ToDouble(max));
//         }
//     }
// }