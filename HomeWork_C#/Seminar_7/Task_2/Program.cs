/* Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */

void PrintArray(int[,] arr)
{    
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($" {arr[i,j]} ");
        }
        Console.Write(" ]");
        Console.WriteLine();
    }
}

void FillArray (int[,] arr, int min, int max)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = new Random().Next(min, max+1);
        }
    }
}

int[,] array = new int[4,4];
FillArray(array, 10, 99);
PrintArray(array);

Console.WriteLine("Введите индекс строки и столбца: ");
int rows = Convert.ToInt32(Console.ReadLine());
int columns = Convert.ToInt32(Console.ReadLine());

if(rows < array.GetLength(0) && columns < array.GetLength(1)) Console.WriteLine(array[rows,columns]);
else Console.WriteLine($"{rows},{columns} такого числа в массиве нет");
    


