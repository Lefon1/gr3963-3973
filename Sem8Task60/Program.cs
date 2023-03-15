int ReadData(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine() ?? "0");
}

int[,,] Gen3DArr(int rows, int columns, int lists, int min, int max)
{
    Random rnd = new Random();
    int[,,] arr = new int[rows, columns, lists];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int k = 0; k < lists; k++)
            {
                while (true)
                {
                    int num = rnd.Next(min, max);
                    if (Array3DX(arr, num) == false)
                    {
                        arr[i, j, k] = num;
                        break;
                    }
                }
            }
        }
    }

    return arr;
}

void Print3DArr(int[,,] arr)
{
    ConsoleColor[] col = new ConsoleColor[] { ConsoleColor.Green, ConsoleColor.Black };
    for (int i = 0; i < arr.GetLength(0); i++)
        {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                Console.ForegroundColor = col[new Random().Next(0, 2)];
                Console.Write($"{arr[i, j, k]} ({i}, {j}, {k})\t");
                Console.Write(arr[i,j,k] +" (" + i + ", " + j +", " + k +")\t");
                Console.Write("{0} ({1}, {2}, {3})\t", arr[i,j,k], i, j, k);
                Console.ResetColor();
            }
            Console.WriteLine();
        }
    }
}

bool Array3DX(int[,,] arr, int number)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                if (arr[i, j, k] == number)
                {
                    return true;
                }
            }
        }
    }
    return false;
}

int rows = ReadData("Введите количество строк для трехмерного массива: ");
int columns = ReadData("Введите количество столбцов для трехмерного массива: ");
int lists = ReadData("Введите количество листов для трехмерного массива: ");

int min = 10;
int max = 99;

int[,,] arr = Gen3DArr(rows, columns, lists, min, max);

Console.WriteLine("");
Print3DArr(arr);