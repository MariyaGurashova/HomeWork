/*
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/


void Print(string text)
{
    Console.WriteLine(text);
}

int GetNum()
{
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

Print("Введите пятизначное число ");
int num = GetNum();

int remains, temp, sum = 0;
if (num>9999 && num < 100000)
{
    for (temp = num; num != 0; num = num/10)
    {
        remains = num % 10;
        sum = sum * 10 + remains;
    }

    if (temp == sum)
    {
    Console.WriteLine($"Число {temp} является палиндромом");
    }
    else
    Console.WriteLine($"Число {temp} не является палиндромом");
}
else
Console.WriteLine("Введите пятизначное число!");

