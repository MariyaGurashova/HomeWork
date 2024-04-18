// Сформируйте двухмерный массив из неповторяющихся двузначных чисел. 

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

void FillArray(int[,] arr)
{
    int count = 10;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = count;
            count +=2;            
        }

    }
}

int[,] array = new int[4, 4];
FillArray(array);
PrintArray(array);