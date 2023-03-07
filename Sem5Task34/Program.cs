// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
// Отсортировать массив методом пузырька
// Отсортируйте массив методом подсчета


//Принимаем из консоли число
int ReadData(string mess)
{
    Console.Write(mess);
    return Convert.ToInt32(Console.ReadLine() ?? "0");
}
//Вывод сообщения на экран
void WriteMess(string mess)
{
    Console.WriteLine(mess);
}
//Генерируем массив случайными числами
int[] Gen1DArr(int len, int bottom, int top)
{
    Random rnd = new Random();
    int[] arr = new int[len];

    for (int i = 0; i < len; i++)
    {
        arr[i] = rnd.Next(bottom, top + 1);
    }

    return arr;
}
//Выводим массив на экран
void PrintData (int[] arr)
{
    Console.Write("[");

    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]},\t");
    }
    Console.WriteLine($"{arr[arr.Length - 1]}]");
}
//Сортировка методом пузырька
int[] BubbleSort(int[] arr)
{
    int temp;
    for (int i = 0; i < arr.Length; i++)
    {
        for (int j = i + 1; j < arr.Length; j++)
        {
            if (arr[i] > arr[j])
            {
                temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }
    }
    return arr;
}
//Сортировка методом подсчета
int[] CountingSort(int[] arr, int q)
{
    var count = new int[q + 1];
    for (var i = 0; i < arr.Length; i++)
    {
        count[arr[i]]++;
    }

    var index = 0;
    for (var i = 0; i < count.Length; i++)
    {
        for (var j = 0; j < count[i]; j++)
        {
            arr[index] = i;
            index++;
        }
    }

    return arr;
}
//Переменные для создания массива,просим ввести значения 
int length = ReadData("Введите длину массива: ");
int min = ReadData("Введите минимальное значение для массива: ");
int max = ReadData("Введите максимальное значение для массива: ");
int[] mas = new int[] { };
if (min > max) { (min, max) = (max, min); }
//Вывод массива
mas = Gen1DArr(length, min, max);
PrintData(mas);
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
//Вывод метода Пузырька
DateTime X1 = DateTime.Now;
PrintData(BubbleSort(mas));
WriteMess($"Метод сортировки пузырьком выполняется за: {DateTime.Now-X1}");
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
//Вывод метода Подсчета
DateTime X2 = DateTime.Now;
PrintData(CountingSort(mas, max));
WriteMess($"Метод сортировки с помощью подсчета выполняется за: {DateTime.Now-X2}");
Console.WriteLine();

