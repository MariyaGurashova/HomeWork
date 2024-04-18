/* Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */

Console.WriteLine("Введите количество строк  ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int columns = Convert.ToInt32(Console.ReadLine());

void PrintArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{(arr[i,j]):F2} ");
        }
        Console.Write("]");
        Console.WriteLine();
    }
}


void FillArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = new Random().NextDouble();
        }
        
    }
}

// В примере к задаче указаны отрицательные числа, целые и дробные, у меня получились только дробные,
// от 0.00 до 1.00, т.к. у NextDouble(), как поняла, именно такой диапазон.
//Как можно прописать диапазон, чтоб получить результат как в примере?
//Вариант, как в одномерном массиве не работает (с указанием min, max в скобках метода и в Random().Next())
//нашла вариант в гугл - array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10; 
//но тогда появляются магичесие цифры в методе + нет полноценного рандома, 100е будут 0ми

double[,] array = new double[rows, columns];

FillArray(array);
PrintArray(array);