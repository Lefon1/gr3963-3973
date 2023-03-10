// Напишите программу, которая перевернёт
// одномерный массив (последний элемент будет на
// первом месте, а первый - на последнем и т.д.)
// Например:
// [1 2 3 4 5] -> [5 4 3 2 1] [6 7 3 6] -> [6 3 7 6]


// Метод, генерирующий массив
int[] GenArray(int len, int minValue, int maxValue)
{
    int[] arr = new int[len];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue + 1);
    }
    return arr;
}

//Метод, выводящий на печать массив
void Print1DArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

void SwapArray(int[] arr)
{
    int bufElem = 0;
    for(int i =0; i<arr.Length/2;i++)
    {
        (arr[i], arr[arr.Length-1-i]) = (arr[arr.Length-1-i], arr[i]);
        // bufElem = arr[i];
        // arr[i] = arr[arr.Length-1-i];
        // arr[arr.Length-1-i]=bufElem;
    }
}

int[] SwapNewArray(int[] arr)
{
    int[] outArr = new int[arr.Length];
    for(int i=0;i<outArr.Length;i++)
    {
        outArr[i] = arr[arr.Length-1-i];
    }
    return outArr;
}

int[] testArray = GenArray(123,10,100);
Print1DArr(testArray);
Console.WriteLine();
SwapArray(testArray);
//int[] newArray = SwapNewArray(testArray);
Print1DArr(testArray);
//Console.WriteLine();
//Print1DArr(newArray);