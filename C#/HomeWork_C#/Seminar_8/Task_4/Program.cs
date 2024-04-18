/* Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */

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

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());

int[,] nums = new int[size, size];

int num = 1;
int i = 0;
int j = 0;

//   00 01 02 03       i<j+1 && i+j <= size-1 j++
//   01 02 03 04 03    i<=j && i+j <= size-1 i++
//56 12       05 13    i>j && i+j < size-1 j--
//46 11       06 23
//36 10 09 08 07 33
//  36 35 34 33   

//решение нашла, с индексами разобралась, не поняла со знаками <=, =>

while (num <= size * size)
{
    nums[i, j] = num;
    if (i <= j + 1 && i + j < size - 1) //Почему если поставить i<j выхожу за рамки массива, есть же size
        ++j;
    else if (i < j && i + j >= size - 1) //А тут на оборот приравниваем к size
        ++i;
    else if (i >= j && i + j > size - 1)//Тут аналог 1го условия, как поняла
        --j;
    else
        --i;
    ++num;
}

Console.WriteLine();
PrintArray(nums);
Console.WriteLine();

