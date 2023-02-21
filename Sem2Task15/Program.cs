// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

// Console.WriteLine("Напишити цифру дня недели");
// // int num = int.Parse(Console.ReadLine());// не выдаёт ошибку
// int num = int.Parse(Console.ReadLine??"0");// выдаёт ошибку
// if(num > 0 && num < 6)
// {
//     Console.WriteLine("это рабочий");
// }
// else
// {
//     Console.WriteLine("это выходной");
// }
//////////////////////////////////////////

Dictionary<int,string> DaysOfWeek = new Dictionary<int, string>();//делаем библиотеку
{
DaysOfWeek.Add(1, "Будний день");//добавляем в библиотеку
DaysOfWeek.Add(2, "Будний день");//добавляем в библиотеку
DaysOfWeek.Add(3, "Будний день");//добавляем в библиотеку
DaysOfWeek.Add(4, "Будний день");//добавляем в библиотеку
DaysOfWeek.Add(5, "Будний день");//добавляем в библиотеку
DaysOfWeek.Add(6, "Выходной");//добавляем в библиотеку
DaysOfWeek.Add(7, "Выходной");//добавляем в библиотеку
};
Console.WriteLine("Напишити цифру дня недели: ");// просим пользователя вести данные 
int Day = int.Parse(Console.ReadLine());//приравниваем значения

if (DaysOfWeek[Day] == "Будний день")//фунцкия по проверки дня недели(выходной или нет)
{
    Console.WriteLine("Будний день!");
}
else
{
    
    Console.WriteLine(" Выходной день! ");
}