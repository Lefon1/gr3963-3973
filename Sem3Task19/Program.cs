﻿// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
// * Сделать вариант через СЛОВАРЬ четырехзначных палиндромов

int ReadInputInt(string mess)
{
    Console.Write(mess);
    return Convert.ToInt32(Console.ReadLine() ?? "0");
}
void WriteMess(string mess)
{
    Console.WriteLine(mess);
}
 int num = ReadInputInt("Введите пятизначное число: ");

if ((num / 10000 == num % 10) && (num / 1000 % 10 == num / 10 % 10))//функцкия на вычесление палиндромов
{
Console.WriteLine("да");//палиндром
}
else
{
Console.WriteLine("нет");// не палиндром
}





////////////////////////////////////
// int ReadInputInt(string mess)
// {
//     Console.Write(mess);
//     return Convert.ToInt32(Console.ReadLine() ?? "0");
// }
// void WriteMess(string mess)
// {
//     Console.WriteLine(mess);
// }


//  int num = ReadInputInt("Введите пятизначное число: ");
// {
//     int len = num.ToString().Length;
//     if (len == 5)
//     {
//         int firstnumber = num / 1000;// вычесляем первые два символа

//         int lastnumber = num % 100;// вычесляем вторые два символа

//         num = firstnumber * 100 + lastnumber;

//         DictionarySearch(DictionaryAdd(), num);
//     }
//     else WriteMess("Вы ввели не пятизначное число");

// }
// Dictionary<int, string> DictionaryAdd()// cоздаем словарь и добавляем в него палинндромы
// {
//     Dictionary<int, string> dict = new Dictionary<int, string>()
//     {
                                
//     [1111] = "палиндром", 	[1221] = "палиндром", 	[1331] = "палиндром" 	[1441] = "палиндром", 	[1551] = "палиндром", 	[1661] = "палиндром", 	[1771] = "палиндром", 	[1881] = "палиндром", 	[1991] = "палиндром", 
//     [2112] = "палиндром", 	[2222] = "палиндром", 	[2332] = "палиндром", 	[2442] = "палиндром", 	[2552] = "палиндром", 	[2662] = "палиндром", 	[2772] = "палиндром", 	[2882] = "палиндром", 	[2992] = "палиндром", 
//     [3113] = "палиндром", 	[3223] = "палиндром", 	[3333] = "палиндром", 	[3443] = "палиндром", 	[3553] = "палиндром", 	[3663] = "палиндром", 	[3773] = "палиндром", 	[3883] = "палиндром", 	[3993] = "палиндром", 
//     [4114] = "палиндром", 	[4224] = "палиндром", 	[4334] = "палиндром", 	[4444] = "палиндром", 	[4554] = "палиндром", 	[4664] = "палиндром", 	[4774] = "палиндром", 	[4884] = "палиндром", 	[4994] = "палиндром", 
//     [5115] = "палиндром", 	[5225] = "палиндром", 	[5335] = "палиндром", 	[5445] = "палиндром", 	[5555] = "палиндром", 	[5665] = "палиндром", 	[5775] = "палиндром", 	[5885] = "палиндром", 	[5995] = "палиндром", 
//     [6116] = "палиндром", 	[6226] = "палиндром", 	[6336] = "палиндром", 	[6446] = "палиндром", 	[6556] = "палиндром", 	[6666] = "палиндром", 	[6776] = "палиндром", 	[6886] = "палиндром", 	[6996] = "палиндром", 
//     [7117] = "палиндром", 	[7227] = "палиндром", 	[7337] = "палиндром", 	[7447] = "палиндром", 	[7557] = "палиндром", 	[7667] = "палиндром", 	[7777] = "палиндром", 	[7887] = "палиндром", 	[7997] = "палиндром", 
//     [8118] = "палиндром", 	[8228] = "палиндром", 	[8338] = "палиндром", 	[8448] = "палиндром", 	[8558] = "палиндром", 	[8668] = "палиндром", 	[8778] = "палиндром", 	[8888] = "палиндром", 	[8998] = "палиндром", 
//     [9119] = "палиндром", 	[9229] = "палиндром", 	[9339] = "палиндром", 	[9449] = "палиндром", 	[9559] = "палиндром", 	[9669] = "палиндром", 	[9779] = "палиндром", 	[9889] = "палиндром", 	[9999] = "палиндром", 

//     };
//     return dict;
// }
// void DictionarySearch(Dictionary<int, string> dict, int numer)
// {
//     if (dict.ContainsKey(numer))
//     {
//         WriteMess($"Введеное число - {dict[numer]}");
//     }
//     else
//     {
//         WriteMess("Введеное число - не палинндром");
//     }

// }
