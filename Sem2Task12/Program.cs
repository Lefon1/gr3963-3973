//Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
//Если второе число некратно первому, то программа выводит остаток от деления.

// // static void Main(string[] args)
// {
// Console.WriteLine("Ведите первое число:");
// int num1 = int.Parse(Console.ReadLine());
// Console.WriteLine("Ведите второе число:");
// int num2 = int.Parse(Console.ReadLine());
// if (num2 % num1 == 0)
// {
// Console.WriteLine("Второе число кратно первому.");
// }
// else
// {
// Console.WriteLine("Второе число не кратно первому. Остаток " + (num2 % num1));
// }
// }
// //////////////////////////////////////////////////////////////////////////////////////////////////////
// Console.Write("Введите первое число: ");
// int firstNum = int.Parse(Console.ReadLine()??"0");
// Console.Write("Введите второе число: ");
// int secondNum = int.Parse(Console.ReadLine()??"0");

// if (firstNum % secondNum == 0)
// {
// Console.WriteLine(secondNum + " кратно " + firstNum);

// }
// else
// {
// Console.WriteLine("Остаток от деления = " + (firstNum % secondNum));
// }

///////////////////////////////////////////////////////////////////////////////////////////////////////
Console.Write("Введите первое число: ");
int firstNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int secondtNum = Convert.ToInt32(Console.ReadLine());
int rem = firstNum % secondtNum;
if(rem == 0)
{
Console.WriteLine($"Число {firstNum} кратно {secondtNum}");
}
else
Console.WriteLine($"Не кратно. Остаток от деления {firstNum} на {secondtNum} = {rem}");