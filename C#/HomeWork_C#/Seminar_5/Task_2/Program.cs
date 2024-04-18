// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

void RandArr(int[] array, int min, int max)
{
    int length = array.Length;

    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(min, max+1);
    }
    Console.WriteLine($"Array => [{String.Join(",", array)}]");
}

int GetSum(int[] array)
{
    int sum = 0;
    int length = array.Length;
    
    for (int i = 0; i < length; i++)
    {
        int temp = array[i];
        if(i % 2 != 0) sum += temp;
        else sum += 0;
    }
    return sum;
}

int[]array = new int[5];
RandArr(array, -30, 30);
int resalt = GetSum(array);
Console.WriteLine($"Resalt = {resalt}");