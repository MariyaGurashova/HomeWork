/* Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */

// А = (A11 A12)   B = (B11 B12)  C = A*B
//     (A21 A22)       (B21 B22)

// C = (A11 * B11 + A12 * B21 || A11 * B12 + A12 * B22) C = (C11 C12)
//     (A21 * B11 + A22 * B21 || A21 * B12 + A22 * B22)     (C21 C22)

//     2*3 + 4*3 = 18 [0,0]
//     2*4 + 4*3 = 20 [0,1]
//     3*3 + 2*3 = 15 [1,0]
//     3*4 + 2*3 = 18 [1,1]

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

void FillFirstArray(int[,] arr, int min, int max)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(min, max + 1);
        }
    }
}

void FillSecondArray(int[,] arr, int min, int max)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(min, max + 1);
        }
    }
}

// с подсчетом разобралась, но решение не мое


void MultiplyMatrix(int[,] firstArray, int[,] secondArray, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstArray.GetLength(1); k++)
      {
        sum += firstArray[i,k] * secondArray[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}


Console.WriteLine();
int[,] firstArray = new int[2, 2];
FillFirstArray (firstArray, 0, 9);
PrintArray(firstArray);
Console.WriteLine();
int[,] secondArray = new int[2, 2];
FillSecondArray (secondArray, 0, 9);
PrintArray(secondArray);
Console.WriteLine();
int[,] resultMatrix = new int[2,2];
MultiplyMatrix(firstArray, secondArray, resultMatrix);
Console.WriteLine($"Произведение первой и второй матриц:");
PrintArray(resultMatrix);
