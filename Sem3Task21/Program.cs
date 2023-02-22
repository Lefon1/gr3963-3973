//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек 
//и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();
// Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()??"0");
}

//Метод выводит данные пользователю
void PrintData(string msg, double val)
{
    Console.WriteLine(msg+val);
}

//Метод находит расстояние между точками на плоскости
double CalcLen3D(int x1, int x2, int y1, int y2,int c1, int c2)
{
    return Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1)+(c2-c1)*(c2-c1));
}
int x1 = ReadData("Введите координату x точки A: ");
int y1 = ReadData("Введите координату y точки A: ");
int c1 = ReadData("Введите координату x точки A: ");
int x2 = ReadData("Введите координату y точки B: ");
int y2 = ReadData("Введите координату x точки B: ");
int c2 = ReadData("Введите координату y точки B: ");

double res = CalcLen3D(x1,x2,y1,y2,c1,c2);

PrintData("Растояние между точками: ", res);

