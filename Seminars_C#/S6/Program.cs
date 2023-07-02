// Задача 40: Напишите программу, которая принимает 
// на вход три числа и проверяет, может ли существовать 
// треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона 
// треугольника меньше суммы двух других сторон.


// int RandomNum()
// {
//     Random rand = new Random();
//     int randomNum = rand.Next(1, 20);
//     return randomNum;
// }

// int a = RandomNum(), b = RandomNum(), c = RandomNum();

// bool CheckTriangle(int a, int b, int c){
//     if((a < (b + c)) && (b < (a + c)) && (c < (a + b))){
//         return true;
//     }
//     return false;
// }

// Console.WriteLine($"Triangle from {a}, {b}, {c} is {CheckTriangle(a, b, c)}.");

/*
Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3  -> 11
2  -> 10
*/

// int number = 2;
// string GetNum(int number){
//     string count = String.Empty;
//     while(number > 0){
//         int result = number%2;
//         count = Convert.ToString(result) + count; // Перемена мест слагаемых (к символу прибавляем накапливаемый результат).
//         number = number/2;
//     }
//     return count;
// }
// Console.WriteLine($"Number {number} is {GetNum(number)}.");

/*
Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8

List<int> list = new List<int>(); // Для создания коллекции (вместо массива, чтобы не определять заранее размер).

Console.WriteLine(string.Join(", ", list));
List.Add(6);
Console.WriteLine(string.Join(", ", list));
List.Add(8);
Console.WriteLine(string.Join(", ", list));

Console.WriteLine(list.Count); // Вернет размер списка.
*/

// List<int> GetFibonacci(int number){
//     List<int> list = new List<int>();
//     list.Add(0);
//     list.Add(1);
//     for (int i = 0; i < number - 2 ; i++)
//     {
//        list.Add((list[list.Count - 1]) + (list[list.Count - 2])); 
//     }
//     return list;
// }
// Console.WriteLine($"Ряд чисел Фибоначчи {string.Join(", ", GetFibonacci(3))}");

/*
Напишите программу, которая будет преобразовывать десятичное число 
в двоичное.
45 -> 101101
3  -> 11
2  -> 10
*/
/*
Console.Clear();
int GetNumber(string description)
    {
    int number;
    Console.WriteLine($"{description} => ");

    while(true)
        {
        string temp = Console.ReadLine();
        if(int.TryParse(temp, out number))
        {
            return number;
        }
        Console.Write($"This number {temp} is not correct. Try again. => ");
    }
    
}
int number = GetNumber("Input number: ");

string FindByteNumber(int number)
{
    string i = String.Empty;
    while(number > 0){
        i = i.Insert(0, Convert.ToString(number%2));
        number/= 2;
    }
    return i;
    
}

string a = FindByteNumber(number);
Console.WriteLine(a);
*/


// Напишите программу, которая принимает на вход три числа и 
// проверяет, может ли существовать треугольник с сторонами 
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника 
// меньше суммы двух других сторон.


/*
Console.Clear();
int GetNumber(string description){

    int number;
    Console.WriteLine($"{description} => ");

    while(true){
        string temp = Console.ReadLine();
        if(int.TryParse(temp, out number)){
            return number;
        }
        Console.Write($"This number {temp} is not correct. Try again. => ");
    }
    
}
int a = GetNumber("Input number: ");
int b = GetNumber("Input number: ");
int c = GetNumber("Input number: ");

bool FindTriangle(int a, int b, int c){
    if((a < b+c) && (b < a+c) && (c < a+b)) return true;
    else return false;
}

string answer = FindTriangle(a, b, c) ? "Yes" : "No";
Console.WriteLine(answer);
*/


// Напишите программу, которая будет создавать копию заданного 
// массива с помощью поэлементного копирования.


// int[] CreateArray(int size, int min, int max){
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++){
//         array[i] = new Random().Next(min, max+1);
//     }
//     return array;
// }

// int[] array = CreateArray(5, 0, 10);
// Console.WriteLine($"Our list [{string.Join(", ", array)}]");


// int[] CopyArray (int[] array){
//     int[] copyArray = new int[array.Length];
//     for(int i = 0; i < array.Length; i++){
//         copyArray[i] = array[i];
//     }
//     return copyArray;
// }

// int[] copyArray = CopyArray(array);
// Console.WriteLine($"Copy list[{string.Join(", ", copyArray)}]");


// Не используя рекурсию, выведите первые N чисел Фибоначчи. 
// Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8


// Console.Clear();
// int GetNumber(string description){

//     int number;
//     Console.WriteLine($"{description} => ");

//     while(true){
//         string temp = Console.ReadLine();
//         if(int.TryParse(temp, out number)){
//             return number;
//         }
//         Console.Write($"This number {temp} is not correct. Try again. => ");
//     }
    
// }
// int n = GetNumber("Input number: ");

// List<int> list = new List<int>();
// list.Add(0);
// list.Add(1);

// for(int i = 2; i < n; i++){
//     list.Add(list[i-1]+list[i-2]);
// }

// Console.WriteLine($"[{string.Join(", ", list)}]");