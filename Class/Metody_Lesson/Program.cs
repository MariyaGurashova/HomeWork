//Метод 1 - ни чего не принимает и не возвращает

void TipeText()
{
    Console.WriteLine("Текст");
}

TipeText();

// Метод 2 - ни чего не возвращает, но может принимать аргументы

void TipeText2(string msg)
{
    Console.WriteLine(msg);
}

TipeText2(msg: "Текст сообщения");

void TipeText21(string msg, int count)
{
    int i = 0;
    while (i<count)
    {
        Console.WriteLine(msg);
        i++;
    }
}

TipeText21("Текст", 4);
// TipeText21(msg: "Текст", count: 4); "именованные аргументы" можно указывать в любом порядке
// TipeText21(count: 4, msg: "Текст");

// Метод 3 - Что-то возвращает, но ни чего не принимает

int Metod3()
{
    return DateTime.Now.Year;
}

int year = Metod3(); // указываем переменную, которой присваиваем значение метода
Console.WriteLine(year);

// Метод 4 - Что-то принимает, и что-то возвращает.

// string Metod4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;
//     while (i<count)
//     {
//         result = result + text;
//         i++;        
//     }
//     return result;
// }

string Metod4(int count, string text)
{
    string result = String.Empty;
    for(int i = 0; i<count; i++)
    {
        result = result + text;  
    }
    return result;
}

 string res = Metod4(10, "Привет; ");
 Console.WriteLine(res);