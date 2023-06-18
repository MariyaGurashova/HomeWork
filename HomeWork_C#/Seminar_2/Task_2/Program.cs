/*
Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/


int Prompt(string message)
{
    Console.Write (message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}


int GetThirdRank(int number)
{
    while (number > 999)
    {
        number /= 10;
    }
    return number % 10;
}

bool ValiDateNumber(int number) // Метод bool используем, когда не нужно возвращать значение, только "правда"/"ложь"
{
    if (number < 100)
    {
        Console.WriteLine("Третьего числа нет");
        return false;
    }
    return true;
}


int number = Prompt ("Ведите число > ");
if (ValiDateNumber(number))
{
    Console.WriteLine (GetThirdRank(number));
}