﻿// Задача №17
// Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.


// <тип> <имя метода>(<тип><название переменной>)
// {
// return <тип>
//}

//метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()??"0");
}
// метод опеределяет четверть по координатам точки
void PrintQuterTest(int x, int y)
{
if(x>0&& y > 0) Console.WriteLine("точка в 1 четверти");

if(x>0&& y < 0) Console.WriteLine("точка в 2 четверти");

if(x>0&& y < 0) Console.WriteLine("точка в 3 четверти");

if(x>0&& y > 0) Console.WriteLine("точка в 4 четверти");
}
int coordX = ReadData("Введите координату Х: ");
int coordY = ReadData("Введите координату Y: ");
PrintQuterTest(coordX, coordY);