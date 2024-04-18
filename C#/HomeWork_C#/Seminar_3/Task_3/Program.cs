/*
Напишите программу, которая принимает на вход координаты двух точек и 
находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

//(x2-x1)*(x2-x1)+(y2-y1)*(y2-y1)+(z2-z1)*(z2-z1)

int GetRand(int min, int max)
{
    int array = new Random().Next(min, max+1);
    return array;
}
/*void Print(string text)
{
    Console.WriteLine(text);
}

int GetNum()
{
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}*/

double GetDis(int x1, int y1, int z1, int x2, int y2, int z2)
{
    int deltax = x2 - x1;
    int deltay = y2 - y1;
    int deltaz = z2 - z1;
    return Math.Sqrt(deltax*deltax+deltay*deltay+deltaz*deltaz);
    /*double resalt = Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1)+(z2-z1)*(z2-z1));
    return resalt;*/
}

/*Print("Введите координаты x1, y1, z1, x2, y2, z2");
int x1 = GetNum();
int y1 = GetNum();
int z1 = GetNum();
int x2 = GetNum();
int y2 = GetNum();
int z2 = GetNum();*/

int x1 = GetRand(-10, 10);
int y1 = GetRand(-10, 10);
int z1 = GetRand(-10, 10);
int x2 = GetRand(-10, 10);
int y2 = GetRand(-10, 10);
int z2 = GetRand(-10, 10);

Console.WriteLine($"(x1 = {x1}), (y1 = {y1}), (z1 = {z1})");
Console.WriteLine($"(x2 = {x2}), (y2 = {y2}), (z2 = {z2})");

double resalt = GetDis(x1, y1, z1, x2, y2, z2);
Console.WriteLine($"Distans {(resalt):F2}");
