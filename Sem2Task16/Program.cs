//Задача №16
//Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

void squareTest(int firstNum, int secondNum)
{
if(firstNum == Math.Pow(secondNum,2))
{
Console.WriteLine($"Число {firstNum} является квадратом {secondNum}");
}
else
{
Console.WriteLine($"Число {firstNum} не является квадратом {secondNum}");
}
}

Console.WriteLine("Введите первое число: ");
int firstNumer = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int secondNumer = Convert.ToInt32(Console.ReadLine());

squareTest(firstNumer,secondNumer);

squareTest(secondNumer,firstNumer);

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
Console.WriteLine("введите число 1");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число 2");
int num2 = Convert.ToInt32(Console.ReadLine());
int quadro1 = Quadro(num1);
int quadro2 = Quadro(num2);

if (quadro1 == num2 || quadro2 == num1)
{
Console.Write("Да");
}
else
{
Console.Write("Нет");
}

int Quadro (int a)
{
return a * a;
}
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////