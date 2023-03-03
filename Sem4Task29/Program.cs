// Задача 29: Напишите программу, которая задаёт массив из N элементов и выводит их на экран. Ввести с клавиатуры длину массива и диапазон значений элементов.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]



// Запрашиваем у пользователя длину массива и диапазон значений элементов
Console.Write("Введите длину массива: ");
int n = int.Parse(Console.ReadLine());

Console.Write("Введите минимальное значение элементов: ");
int minValue = int.Parse(Console.ReadLine());

Console.Write("Введите максимальное значение элементов: ");
int maxValue = int.Parse(Console.ReadLine());

// Создаем массив со случайными значениями в заданном диапазоне
int[] array = new int[n];
Random random = new Random();
for (int i = 0; i < n; i++)
{
    array[i] = random.Next(minValue, maxValue + 1);
}

// Выводим массив на экран
Console.WriteLine("Массив из " + n + " элементов со значениями от " + minValue + " до " + maxValue + ":");
foreach (int element in array)
{
    Console.Write(element + " ");
}