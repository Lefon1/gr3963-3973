// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

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
//Метод для рекурсивного вычисления суммы целых чисел в заданном диапазоне
int RecSumDigMN(int m, int n)
{
    if (m >= n)
    {
        return n;
    }
    else
    {
        return m + RecSumDigMN(m + 1, n);
    }
}
//Считываем два числа с консоли и вызываем метод 
int num1 = ReadData("Введите значение M: ");
int num2 = ReadData("Введите значение N: ");
//Выводим результат на консоль
PrintData($"Ответ = {RecSumDigMN(num1, num2)}");