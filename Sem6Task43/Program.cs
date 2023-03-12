// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// *Найдите площадь треугольника образованного пересечением 3 прямых



double ReadData(string message)
{
  Console.Write(message);
  double num = Convert.ToDouble(Console.ReadLine()!);
  return num;
}

void PrintDataX(double k1, double b1, double k2, double b2)
{
  double x = (b1 - b2) / (k2 - k1);

  double y1 = k1 * x + b1;
  double y2 = k2 * x + b2;
  Console.Write($" -> ({y1}; {y2})");
}

double k1 = ReadData($"Введите k1: ");
double b1 = ReadData($"Введите b1: ");
double k2 = ReadData($"Введите k2: ");
double b2 = ReadData($"Введите b2: ");
Console.Write($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} ");
PrintDataX(k1, b1, k2, b2);