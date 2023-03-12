// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
// *При выводе матрицы показывать каждую цифру разного цвета(цветов всего 16)
//========================================================================================================================================================================================

Console.Clear();//очищение консоли
int ReadData(string line)// Функция для чтения целочисленных данных с консоли
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

double[,] Gen2DArr(int Row,int Coloumn,int min,int max)// Проверяем, что минимальное значение не больше максимального
{
    if (min > max)// Если минимальное больше максимального, меняем их местами
    {
        int buf = min;
        min = max;
        max = buf;
    }
    double[,] arr=new double[Row,Coloumn];// Создаем двумерный массив с заданным количеством строк и столбцов
    for(int i=0;i<Row;i++)// Заполняем массив случайными вещественными числами в диапазоне от min до max
    {
        for(int j=0;j<Coloumn;j++)
        {
            arr[i,j]=new Random().Next(min,max) + new Random().NextDouble();
        }
    }
    return arr;// Возвращаем сгенерированный массив
} 
//===============================================================================================================
// void Print2DArr(double[,] arr)
// {
//     ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
//                                         ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
//                                         ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
//                                         ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
//                                         ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
//                                         ConsoleColor.Yellow};

//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             Console.ForegroundColor = col[new Random().Next(0,16)];
//             Console.Write(arr[i, j] + "  ");
//             Console.ResetColor();
//         }
//         Console.WriteLine();
//     }
// }
//===============================================================================================================
// void Print2DArr(double[,] arr)
// {
//     ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
//                                         ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
//                                         ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
//                                         ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
//                                         ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
//                                         ConsoleColor.Yellow};

//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             Console.ForegroundColor = col[new Random().Next(0,16)];
//             Console.Write("{0:f2}  ", arr[i, j]);
//             Console.ResetColor();
//         }
//         Console.WriteLine();
//     }
// }
//===============================================================================================================
// void Print2DArr(double[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             Console.ForegroundColor = (ConsoleColor)new Random().Next(1, 16);
//             Console.Write("{0:f2}  ", arr[i, j]);
//         }
//         Console.ResetColor();
//         Console.WriteLine();
//     }
// }
//===============================================================================================================
void Print2DArr(double[,] arr)// Функция для вывода двумерного массива
{
    ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                        ConsoleColor.Yellow};

    int[] usedColors = new int[16];// Массив, который хранит информацию о том, какие цвета уже использованы

    for (int i = 0; i < arr.GetLength(0); i++)   // Выводим элементы массива на консоль с цветными символами
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            int colorIndex = new Random().Next(0,16);// Генерируем случайный индекс для выбора цвета

            while (usedColors[colorIndex] == 1)// Если цвет уже был использован, генерируем новый индекс до тех пор,
            // пока не найдем неиспользованный цвет
            {
                colorIndex = new Random().Next(0,16);
            }

            usedColors[colorIndex] = 1;// Помечаем, что цвет использован

            Console.ForegroundColor = col[colorIndex];// Устанавливаем цвет символа
            Console.Write("{0:f2}  ", arr[i, j]);// Выводим элемент массива на консоль с двумя знаками после запятой
            Console.ResetColor();  // Сбрасываем цвет символа
        }

        for (int k = 0; k < 16; k++)// Обнуляем массив использованных цветов для следующей строки
        {
            usedColors[k] = 0;
        }

        Console.WriteLine("\t");// Переходим на новую строку
    }
}
// Читаем количество строк, столбцов, минимальное и максимальное значения
int Row = ReadData("Введите количество строк : ");
int Coloumn = ReadData("Введите количество столбцов: ");
int min = ReadData("Введите 1 границу последовательности: ");
int max = ReadData("Введите 2 границу последовательности: ");
double[,] mas = Gen2DArr(Row, Coloumn, min, max);// Генерируем двумерный массив вещественных чисел
Print2DArr(mas);// Выводим массив на консоль