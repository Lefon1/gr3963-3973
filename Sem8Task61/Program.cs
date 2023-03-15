//Вывести первые N строк треугольника Паскаля.
// Сделать вывод в виде равнобедренного треугольника

// Чтение данных из консоли
// int ReadData(string line)
// {
//     Console.Write(line);
//     int number = int.Parse(Console.ReadLine() ?? "0");
//     return number;
// }

// //n!/k!*(n-k)!
// long Factoreal(int n)
// {
//     long res = 1;
//     for(int i=1;i<=n;i++)
//     {
//         res=res*i;
//     }
//     return res;
// }

// //           1
// //          1 1
// //         1 2 1
// void PrintPascalTriangle(int nRow)
// {
//     for(int i=0;i<nRow;i++)
//     {
//         for(int k =0;k<nRow-i;k++)
//         {
//             Console.Write(" ");
//         }

//         for(int j =0; j<=i;j++)
//         {
//            Console.Write(" ");
//            Console.Write(Factoreal(i)/(Factoreal(j)*Factoreal(i-j)));
//         }
//         Console.WriteLine();
//     }
// }

// int countRow = ReadData("Введите количество строк треугольника Паскаля: ");
// PrintPascalTriangle(countRow);
////////////////////////////////////////////////////////////////////////////////////////////////////



// Функция для чтения данных из консоли
// Принимает строку, которую нужно вывести перед вводом
// Возвращает число, введенное пользователем
int ReadData(string line)
{
    Console.Write(line); // выводим строку перед вводом данных
    int number = int.Parse(Console.ReadLine() ?? "0"); // читаем введенные данные и преобразуем их в целое число
    return number; // возвращаем полученное число
}

// Функция для вычисления факториала
// Принимает число n и возвращает его факториал
long Factoreal(int n)
{
    long res = 1; // переменная для хранения результата
    for (int i = 1; i <= n; i++) // цикл для перемножения чисел от 1 до n
    {
        res = res * i; // умножаем текущее число на результат предыдущих умножений
    }
    return res; // возвращаем полученный результат
}

// Функция для печати треугольника Паскаля
// Принимает количество строк, которое нужно вывести
void PrintPascalTriangle(int nRow)
{
    for (int i = 0; i < nRow; i++) // цикл по строкам
    {
        for (int k = 0; k < nRow - i; k++) // цикл для выравнивания строк
        {
            Console.Write(" "); // выводим пробелы
        }
        for (int j = 0; j <= i; j++) // цикл для вывода чисел в строке
        {
            Console.Write(" "); // выводим пробел перед числом
            Console.Write(Factoreal(i) / (Factoreal(j) * Factoreal(i - j))); // вычисляем значение числа и выводим его
        }
        Console.WriteLine(); // переходим на новую строку
    }
}

int countRow = ReadData("Введите количество строк треугольника Паскаля: "); // читаем количество строк из консоли
PrintPascalTriangle(countRow); // выводим треугольник Паскаля