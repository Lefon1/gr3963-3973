//Задача №31
//Задайте массив из 12 элементов, заполненный случайными числами 
//из промежутка [-9, 9]. Найдите сумму отрицательных 
//и положительных элементов массива.

int[] Gen1DArr(int len, int minValue, int maxValue)
{
    if (minValue > maxValue)//блок корректировки входных данных
    {
        int buf = minValue;
        minValue = maxValue;
        maxValue = buf;
    }


    Random rnd = new Random();
    int[] arr = new int[len];

    for (int i = 0; i < len; i++)
    {
        arr[i] = rnd.Next(minValue=100, maxValue=999);
    }

    return arr;
}

void Print1DArr(int[] arr)//печатаем одномерный массив
{
    Console.Write("[");

    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.WriteLine($"{arr[arr.Length - 1]}]");
}

void PrintData(string res, int value)
{
    Console.WriteLine(res + value);
}

(int posit,int negot)NegPosSum(int[] arr )
{
    int positSum = 0;
    int negotSum = 0;

    for(int i=0;i<arr.Length;i++)
    {
        if(arr[i] > 0)
        {
            positSum += arr[i];
        }
        else
        {
            negotSum += arr[i];
        }
        
        
    }

    return (positSum,negotSum);
}


int[] testArr = Gen1DArr(12,-9,9);
Print1DArr(testArr);
DateTime d2 = DateTime.Now;
(int posit,int negot) results = NegPosSum(testArr);
Console.WriteLine(DateTime.Now - d2);
PrintData("сумма положит ",results.posit);
PrintData("сумма неготив ",results.negot);
