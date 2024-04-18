// 
string[,] table = new string[2, 5]; //[2,5] 2 - количество строк, 5 - столбцов
// String.Empty
// table[0,0] table[0,1] table[0,2] table[0,3] table[0,4]
// table[1,0] table[1,1] table[1,2] table[1,3] table[1,4]


// table[1, 2] = "Слово";
// for (int rows = 0; rows < 2; rows++) // rows строки, rows<2, т.к. строк 2
// {
//     for (int columns = 0; columns < 5; columns++) //columns - столбцы = 5
//     {
//         Console.WriteLine($"-{table[rows, columns]}-"); // Вызываем на печать наш массив, table наш массив,
//     }                                                 // в индексе указываем индекс строки и столбца
// }


// int[,] matrix = new int[3, 4];
// for (int rows = 0; rows < matrix.GetLength(0); rows++)//Уходим от магических цифр, была 3, 0 кол-во строк
// {
//     for (int columns = 0; columns < matrix.GetLength(1); columns++)//Уходим от магических цифр, была 4, 1 - столбцов
//     {
//         Console.Write($"{matrix[rows, columns]} ");//Вывод всех столбиков в текущей строчке
//     }
// Console.WriteLine();// Принудительный переход на новую строку, для получения таблицы(матрицы)
// }


//Создаем метод выводящий на печать нашу матрицу

void PrintArray(int[,] matr)
{
    for (int rows = 0; rows < matr.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matr.GetLength(1); columns++)
        {
            Console.Write($"{matr[rows, columns]} ");
        }
    Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(1, 10); // полуинтервал [1,10), 10 не входит
        }
    }
}

int[,] matrix = new int [3,4];

PrintArray(matrix); // убеждаемся что у нас нолики
FillArray(matrix);  // заполняем массив
Console.WriteLine();
PrintArray(matrix); // снова распечатываем