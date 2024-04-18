/* Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/


int Max(int args1, int args2, int args3)
{
    int resalt = 0;
    if (args1 > resalt) resalt = args1;
    if (args2 > resalt) resalt = args2;
    if (args3 > resalt) resalt = args3;
    return resalt;
}

int[] array = {500,89,126};

int resalt = Max(array[0], array[1], array[2]);

Console.WriteLine(resalt);

