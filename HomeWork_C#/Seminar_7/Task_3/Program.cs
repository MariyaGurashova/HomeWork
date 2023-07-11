/* Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($" {arr[i, j]} ");
        }
        Console.Write(" ]");
        Console.WriteLine();
    }
}

void FillArray(int[,] arr, int min, int max)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(min, max + 1);
        }
    }
}

void GetAvg(int[,] array)
{
    Console.Write("Среднее арифметическое каждого столбца: ");
    int i, j;
    for (j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (i = 0; i < array.GetLength(0); i++)
        {
            sum = sum + array[i, j];
        }
        Console.Write($"{(sum / i):F2}; ");
    }
}

int[,] array = new int[4, 4];
FillArray(array, 1, 9);
Console.WriteLine();
PrintArray(array);
GetAvg(array);









