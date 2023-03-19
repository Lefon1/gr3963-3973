// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
////////////////////////////////////////////////////////////////////////////////////////////////////////////

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

// Определение функции для чтения данных с консоли
int Ackermann(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return Ackermann(m - 1, 1);
    }
    else
    {
        return Ackermann(m - 1, Ackermann(m, n - 1));
    }
}
// Чтение значений m и n с консоли и вызов функции Ackermann для их вычисления
int num1 = ReadData("Введите значение M: ");
int num2 = ReadData("Введите значение N: ");
PrintData($"Ответ = {Ackermann(num1, num2)}");