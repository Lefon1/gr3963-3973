// Задача №22
// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу квадратов чисел от 1 до N.

int ReadInput(string mess)
{
    Console.Write(mess);
    return Convert.ToInt32(Console.ReadLine() ?? "0");
}

void LineBuilder(int end, int pow)
{
    string res = String.Empty;
    
    for(int i = 1; i<=end; i++)
    {
        Console.Write($"{Math.Pow(i,pow)}\t");
    }

    Console.WriteLine();
}



int N = ReadInput("Введите конечное число: ");
LineBuilder(N,1);
LineBuilder(N,2);

