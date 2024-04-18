// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

void GetRandArr(double[] array)
{
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().NextDouble();
        Console.Write($"{array[i]:F2} ");
    }
    // Console.WriteLine($"Array => [{string.Join(", ", Math.Round(array, 2))}]");
}

void SelectionSort(double[] array)
{
     
    for (int i = 0; i < array.Length; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }
    

    double temp = array[i];
    array[i] = array[minPosition];
    array[minPosition] = temp;
    Console.Write($"{Math.Round(array[i], 2, MidpointRounding.ToZero)} ");
    }
}


double GetResult(double[] array)
{
    double min = array[0];
    double max = array[0];
    
    foreach (double item in array)
    {
        if(min > item) min = item;
        if(max < item) max = item;
    }
     
    return max - min;
}

double[] array = new double[4];
GetRandArr(array);
Console.WriteLine();

SelectionSort(array);
Console.WriteLine();

double result = GetResult(array);
Console.WriteLine($"{(result):F2}");

