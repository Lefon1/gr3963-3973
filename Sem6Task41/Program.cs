// No41 Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл
// пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3
// * Пользователь вводит число нажатий, затем программа следит за нажатиями и
// выдает сколько чисел больше 0 было введено.



int ReadData(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine() ?? "0");
}

void PrintData(string msg)
{
    Console.WriteLine(msg);
}

int CountNum(int numM)
{
    int res = 0;
    for(int i = 0; i<numM;i++)
    {
        if(ReadData(" ")>0)
        {
            res++;
        }
    }
    return res;
}

int m = ReadData("Введите количество чисел: ");
int res = CountNum(m);
PrintData($"Количество чисел >0: {res}");

