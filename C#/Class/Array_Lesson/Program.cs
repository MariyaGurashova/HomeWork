// Определение меньшего значения в массиве и его перенос в самое начало

int[] arr = {6, 8, 2, 4, 6, 5, 5, 6, 8};

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

// void SelectionSort(int[] array)
// {
//     for (int i = 0; i < array.Length - 1; i++)  // Важно!! -1, чтоб не выйти за рамки массива
//     {
//         int minPosition = i;

//         for (int j = i + 1; j < array.Length; j++)  // +1 Чтоб сравнивать со следующим числом массива
//         {
//             if(array[j] < array[minPosition]) minPosition = j;
//         }
    
//     int temp = array[i];
//     array[i] = array[minPosition];
//     array[minPosition] = temp;
//     }

// }

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int MaxPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] > array[MaxPosition]) MaxPosition = j;
        }
        int temp = array[i];
        array[i] = array[MaxPosition];
        array[MaxPosition] = temp;
    }
}

PrintArray(arr);     //Печать первичного массива
SelectionSort(arr);  //Сортирока массива
PrintArray(arr);     //Печать нового массива