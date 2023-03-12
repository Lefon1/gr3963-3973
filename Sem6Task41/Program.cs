// No41 Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл
// пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3
// * Пользователь вводит число нажатий, затем программа следит за нажатиями и
// выдает сколько чисел больше 0 было введено.



// int ReadData(string message)
// {
//     Console.Write(message);
//     return int.Parse(Console.ReadLine() ?? "0");
// }

// void PrintData(string msg)
// {
//     Console.WriteLine(msg);
// }

// int CountNum(int numM)
// {
//     int res = 0;
//     for(int i = 0; i<numM;i++)
//     {
//         if(ReadData(" ")>0)
//         {
//             res++;
//         }
//     }
//     return res;
// }

// int m = ReadData("Введите количество чисел: ");
// int res = CountNum(m);
// PrintData($"Количество чисел >0: {res}");

//===================================================================================================================
//Вариант со звездочкой
//===================================================================================================================


using System.Text.RegularExpressions; // Без явного указания сборки не работают регулярные выражения.
int taps = ReadData("Введите количество нажатий");
string inputLine=ReadLineData("Введите любые символы с клавиатура");
Console.WriteLine(inputLine);
FindNumbersInString(inputLine,taps);

int ReadData(string message)// Метод запрашивает и считывает данные с консоли
{
    Console.Write(message);
    return int.Parse(Console.ReadLine() ?? "0");
}

string ReadLineData(string msg)// метод считывает нажатие клавиш на клавитуре заданное клоичество раз и собирает
{
Console.WriteLine(msg);
string line = "";
for (int i=0; i < taps; i++)
{
    var key = Console.ReadKey(true); // параметр true указан для того чтобы тпосле нажатия клавиш ничего не появлялось в консоли.
    line = line + String.Format(key.KeyChar.ToString())+ ",";
    }
    line = line.TrimEnd(','); // кусь последнюю запятую
    return line;
}
void FindNumbersInString(string str,int count)// метод для поиска десятичных цифр в строке с помощью регулярных выражений.
{
Regex regex = new Regex(@"\d"); //задаем для поиска "любая десятичная цифра"
MatchCollection matches = regex.Matches(str);//задаем коллекцию состоящую из найденных по условию выражений
int posNums = 0;
if (matches.Count >0)// если цифры найдены, то накапливаем результат.Каждая найденная цирфа +1 к итогу.
{
    foreach(Match match in matches)
    {
        posNums = posNums +1;
    }
    Console.WriteLine($"Вы совершили нажатий:- {count}. Среди введеных символов найдено чисел- {posNums}");
}
else
{
    Console.WriteLine($"Вы совершили нажатий:- {count}. Среди введеных символов чисел не найдено");
}
}