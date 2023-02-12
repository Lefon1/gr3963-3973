//Напишите программу, которая будет выдавать название дня недели по заданному номеру.

//Console.Write("Введите число");
//var day = Convert.ToInt32(Console.ReadLine());

//if(day > 7)
//{
 //   day = day % 7;
//}
//else
//{
    //Console.WriteLine("Введите номер дня недели")
//}

//string[] dayWeek = {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота"};
//Console.WriteLine(dayWeek[day-1]);


////////////////////////////////////////////////////////////////////////////////////////////////////
Console.Write("Введите номер дня недели: ");
string? lineDay = Console.ReadLine();

if(lineDay!=null)
{
    int day = int.Parse(lineDay);
    string[] dayWeek = new string[7];
    //dayWeek[0] = "Понедельник";
    //dayWeek[1] = "Вторник";
    //dayWeek[2] = "Среда";
    //dayWeek[3] = "Четверг";
    //dayWeek[4] = "Пятница";
    //dayWeek[5] = "Суббота";
    //dayWeek[6] = "Воскресенье"; 
    
    string outDayOfWeek = System.Globalization.CultureInfo.GetCultureInfo("ru-Ru").DateTimeFormat.GetDayName((DayOfWeek)Enum.GetValues(typeof(DayOfWeek)).GetValue(day));


    Console.WriteLine(outDayOfWeek);
}