/* Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */


void GetText()
{
    Console.Write("Введите количество элементов массива: ");
}

GetText();

int number = Convert.ToInt32(Console.ReadLine());
int[] array = new int[number];

void PrintArray(int number)
{
    for (int i = 0; i < number; i++)
    {
        Console.Write($"Введите {i + 1} элемент массива ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
}

PrintArray(number);

int FoundSum(int[] array)
{
    int sum = 0;
    int i = 0;
    while (i < array.Length)
    {
        if(array[i] > 0) sum = sum + 1;
        i = i + 1;
    }
    return sum;
}


int sum = FoundSum(array);
Console.WriteLine($"Чисел больше нуля: {sum}");
