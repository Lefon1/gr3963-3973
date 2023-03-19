// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N. Выполнить с помощью рекурсии.
// N = 5 -> "1, 2, 3, 3, 4"
// N = 8 -> "1, 2, 3, 4, 5, 6, 7, 8"
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

// Определение функции для чтения данных с консоли
int ReadData(string mess)
{
    Console.Write(mess);
    return Convert.ToInt32(Console.ReadLine() ?? "0");
}

// Определение функции для вывода данных на консоль
void PrintData(string mess)
{
    Console.WriteLine(mess);
}

// Определение функции для генерации строки
string LineGenRec(int N, int numer)
{
    string res = String.Empty;

    if (numer <= N)
    {
        res += numer + " " + LineGenRec(N, numer + 1);
        return res;
    }
    else
    {
        return res;
    }
}

// Чтение числа N с консоли и вывод сгенерированной строки
int num = ReadData("Введите число N: ");
PrintData($"{LineGenRec(num, 1)}");