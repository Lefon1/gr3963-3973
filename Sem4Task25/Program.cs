//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

//Принимаем данные из консоли
int ReadInputInt(string mess)
{
    Console.Write(mess);
    return Convert.ToInt32(Console.ReadLine() ?? "0");
}
//принимаем из консоли символ
char ReadInputChar(string mess)
{
    Console.Write(mess);
    return Convert.ToChar(Console.ReadLine() ?? "0");
}
//Метод для вывода данных
void WriteMess(string mess)
{
    Console.WriteLine(mess);
}

//Делаем калькулятор
double Calculate(int A, char op, int B)
{
    switch (op)
    {
        case '+': return A + B;
        case '-': return A - B;
        case '*': return A * B;
        case '/': return A / B;
        case '^': return Math.Pow(A, B);
        default:
            WriteMess("\nНеизвестная операция");
            return 0;
    }
}
//Вводим число1
int numberA = ReadInputInt("Введите первое число: ");

char sign = ReadInputChar("" +
        "\nВыберете действие:" +
        "\n Сложения: +" +
        "\n Вычитания: -" +
        "\n Умножения: *" +
        "\n Деления: /" +
        "\n Возведения в степень: ^" +
        "\n Ваш выбор: ");

//Вводим число2
int numberB = ReadInputInt("Введите второе число: ");
double res = Calculate(numberA, sign, numberB);

//Выводим ответ
WriteMess($" {numberA} {sign} {numberB} = {res}");