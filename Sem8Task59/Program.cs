// Метод для чтения данных из консоли.
int ReadData(string line)
{
    // Выводим вопрос пользователю.
    Console.Write(line);
    
    // Считываем ответ пользователя и парсим его в целочисленное значение.
    // В случае, если введенная строка не может быть преобразована в число,
    // метод вернет значение 0.
    int number = int.Parse(Console.ReadLine() ?? "0");
    
    // Возвращаем прочитанное число.
    return number;
}

// Метод для вывода двумерного массива в консоль с различными цветами.
void Print2DArrayColor(int[,] matrix)
{
    // Создаем массив из 16 цветов для вывода элементов массива в консоль.
    ConsoleColor[] col = new ConsoleColor[] { ConsoleColor.Black, ConsoleColor.Blue, ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue, ConsoleColor.DarkCyan, ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen, ConsoleColor.DarkMagenta, ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow, ConsoleColor.Gray, ConsoleColor.Green,
                                        ConsoleColor.Magenta, ConsoleColor.Red, ConsoleColor.White,
                                        ConsoleColor.Yellow };
    
    // Проходим по всем элементам двумерного массива.
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            // Получаем цвет для текущего элемента.
            Console.ForegroundColor = col[matrix[i, j] % 15];
            
            // Выводим элемент массива с дополнительными пробелами,
            // чтобы выровнять все столбцы.
            Console.Write(matrix[i, j] + "     ".Substring(matrix[i, j].ToString().Length));
            
            // Сбрасываем цвет консоли.
            Console.ResetColor();
        }
        
        // Переходим на новую строку.
        Console.WriteLine();
    }
}

// Метод для заполнения двумерного массива случайными числами.
int[,] Fill2DArray(int countRow, int countColumn, int topBorder, int downBorder)
{
    // Создаем генератор случайных чисел.
    System.Random rand = new System.Random();
    
    // Создаем пустой двумерный массив.
    int[,] array2D = new int[countRow, countColumn];
    
    // Заполняем массив случайными числами в заданном диапазоне.
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            array2D[i, j] = rand.Next(topBorder, downBorder + 1);
        }
    }
    
    // Возвращаем заполненный массив.
    return array2D;
}

// Метод для поиска минимального элемента в двумерном массиве.
// Возвращает координаты минимального элемента в массиве.
(int x, int y) SearchMinElementIn2DArray(int[,] matrix)
{
    // Инициализируем начальное значение минимального элемента.
    int row = 0;
    int collumn = 0;
    int min = int.MaxValue;
    
    // Проходим по всем элемент
}