// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


// void GetNumber()
// {
//     Console.WriteLine("Введите число ");
//     int number = Convert.ToInt32(Console.ReadLine());
// }

// GetNumber();

void Print(string text)
{
    Console.WriteLine(text);
}

int GetRand(int min, int max)
{
    int number = new Random().Next(min, max);
    return number;
}

int GetSum(int number)
{
    int summa = 0;
    int temp = 0;

    while (number!=0)
    {
        temp = number % 10;
        summa = summa + temp;
        number/=10;
    }
    return summa;
}



int number = GetRand(0, 500);
Print($"Rand number = > {number}");

int resalt = GetSum(number);
Print($"Сумма всех цифр в числе => {resalt}");
