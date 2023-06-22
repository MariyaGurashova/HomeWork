/*
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

/*
void Print(string text)
{
    Console.WriteLine(text);
}

int GetNum()
{
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

Print("Введите число");
int temp = GetNum();
*/
int GetRandNum(int min, int max)
{
    int resalt = new Random().Next(min, max+1);
    return resalt;
}

void Print(string text)
{
    Console.WriteLine(text);
}

void GetCube(int rand)
{
    for (int i = 1; i <= rand; i++)
    {
        Console.Write($"{Math.Pow(i, 3)} ");
    }
    
}

int rand = GetRandNum (1, 10);
Print($"Число => {rand}");
GetCube(rand);
