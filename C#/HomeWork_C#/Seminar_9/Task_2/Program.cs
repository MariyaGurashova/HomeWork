/* Задайте значения M и N. Напишите программу, которая найдёт 
сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

Console.WriteLine("Введите число m ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n ");
int n = Convert.ToInt32(Console.ReadLine());

int GetSum(int m, int n)
{
    if(m > n) return 0;  
    return m + GetSum(m+1, n);
}

Console.Write($"Summa => {GetSum(m,n)} ");

