// Напишите программу, которая выводит случайное
// число из отрезка [10, 99] и показывает наибольшую
// цифру числа.

// Например:
// 78 -> 8
// 12-> 2
// 85 -> 8


System.Random numSintezator = new System.Random();// выделяем оперативную память//Синтезатор рандоиных чисел

// Вариант 1
int rndNumber = numSintezator.Next(10,100);
Console.WriteLine(rndNumber);
int firstNum = rndNumber/10;// старший разряд
int secondNum = rndNumber%10;// остаток от деления на 10


if(firstNum>secondNum)
{
Console.WriteLine("первое число больше " + firstNum + " второго " + secondNum);
}
else
{
Console.WriteLine(secondNum);
}


// Вариант 2

char[] digits = numSintezator.Next(10,100).ToString().ToCharArray();// char[]'массив' digits'название массива' = numSintezator.Next(10,100).ToString().ToCharArray();
Console.WriteLine(digits);
int firstNumber = ((int)digits[0])-48;//int+num=5//смотри запись в тетрадке
int secondNumber = ((int)digits[1])-48;

//<переменная = (условие)?<значение1>:<значение2>;
///////////////
//if(Условие)
//{
//    <переменная> = <значение1>;
//}
//else
//{
//    <значение1> = <значение2>
//}
int resultNumber = (firstNumber>secondNumber)?resultNumber=firstNumber:resultNumber=secondNumber;
Console.WriteLine(resultNumber);

//Вариант 3
int rndNumberArr = numSintezator.Next(10,100);
Console.WriteLine(rndNumberArr);
int[] indexAnsw =new int[90];

// Выводим данные в консоль
Console.WriteLine(indexAnsw[rndNumberArr-10]);