// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

void FillArr(int[] array, int min, int max)
{
    int length = array.Length;
    int i = 0;
    while (i<length)
    {
        array[i] = new Random().Next(min, max+1);
        i++;
    }
        Console.WriteLine($"Array => [{string.Join(", ", array)}]");
}

int GetEvenNum(int[] array)
{
    int temp = 0;
    foreach (int item in array)
    {
        if (item % 2 == 0) temp +=1;
        else temp +=0;
    }
    return temp;
}

int[] arr = new int[4];
FillArr(arr, 100, 999);
int result = GetEvenNum(arr);
Console.WriteLine($"Количество чётных чисел в массиве => {result}");
