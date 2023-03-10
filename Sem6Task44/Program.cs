// Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Например:
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

int ReadDataToInt(string msg)
{
    Console.Write(msg);
    return (int.Parse(Console.ReadLine() ?? "0"));
}
string FiboNum(int num)
{
    string res = "0 1";
    int first = 0; int last = 1; 
    for (int i = 2; i < num; i++)
    {
        res = res + " " + (first + last).ToString();
        (first, last) = (last, first + last);
    }
    return res;
}
int num = ReadDataToInt("Enter a number of Fibonacci elements: ");
Console.WriteLine(FiboNum(num));