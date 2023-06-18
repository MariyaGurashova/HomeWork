/*Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

Console.WriteLine("Введите число ");
int caseSwitch = Convert.ToInt32(Console.ReadLine());

switch(caseSwitch)
{
    case 1:
        Console.WriteLine("Понедельник");
        break;
    case 2:
        Console.WriteLine("Вторник");
        break;
    case 3:
        Console.WriteLine("Среда");
        break;
    case 4:
        Console.WriteLine("Четверг");
        break;
    case 5:
        Console.WriteLine("Пятница");
        break;
    case 6:
        Console.WriteLine("Суббота");
        break;
    case 7:
        Console.WriteLine("Воскресенье");
        break;
}


bool CaseDay(int day)
{
    if (day == 6)
    {
        //Console.WriteLine("Выходной");
        return true;
    }
    
    if (day == 7)
    {
        //Console.WriteLine("Выходной");
        return true;
    }
    return false;
}

int day = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(CaseDay(day));
