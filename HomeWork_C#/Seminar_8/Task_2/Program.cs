/* Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и 
выдаёт номер строки с наименьшей суммой элементов: 1 строка */

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
// Это мой метод подсчета сумм по строкам, работает, но дальше решить не смогла.
// Пыталась полученные суммы преобразовать в одномерный массив и там уже производить сравнение, 
// но на этом этапе застряла. Не понимаю как это сделать.
// Ниже нашла решение в интернете, но не доканца в нем разобралась

/* void GetSum(int[,] array)
{
    Console.Write("Сумма элементов по каждой строке: ");
    
    int i, j;
    for (i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];
        }
        Console.Write($" {sum} ");
    }
    
} */


Console.WriteLine();
int[,] array = new int[5, 4];
FillArray(array, 0, 9);
PrintArray(array);
Console.WriteLine();
// GetSum(array);
// int[] newArray = GetSum(array);
// Console.WriteLine(String.Join(", ", newArray));

// Функция, считающая сумму элементов в строке
int SumLine(int[,] array, int i)
{
    int sum = array[i, 0]; 
    for (int j = 1; j < array.GetLength(1); j++)
    {
        sum += array[i, j];
    }
    return sum;
}

int minSum = 1;
int sum = SumLine(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
    if (sum > SumLine(array, i))
    {
        sum = SumLine(array, i);
        minSum = i + 1;
    }
}
Console.WriteLine($"\nСтрока c наименьшей суммой элементов: { minSum}");



