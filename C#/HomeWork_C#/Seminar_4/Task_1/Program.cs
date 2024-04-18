// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


// void PrintArray()
// {
//     Console.Write($"Массив => ");
// }

void GetRandArr(int[] collection, int min, int max)
{
    int length = collection.Length;
    int i = 0;

    while (i < length)
    {
        collection[i] = new Random().Next(min, max);
        i++;
    }
    Console.WriteLine($"[{string.Join(", ", collection)}]");
}

// PrintArray();
int[] arr =  new int [8];
GetRandArr(arr, 0, 89);
