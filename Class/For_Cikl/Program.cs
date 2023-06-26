// Таблица умножения


// for (int i = 2; i <= 9; i++)
// {
//         for (int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} x {j} = {i*j}");
//     }
//     Console.WriteLine();
// }

//Дан текст. Нужно заменить:
//Все пробелы заменить черточками
//Маленькие буквы "к" заменить большимиб
//Большие "С" заменить на меленькие

string text = "- Я думаю, сказал княть, улыбаясь, - что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"
//             0123
//s[3] // r

string RepLace(string text, char oldValue, char newValue)
{
    string resalt = String.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {                                             
        if(text[i] == oldValue) resalt = resalt + $"{newValue}"; // можно просто newValue
        else resalt = resalt + $"{text[i]}"; // можно просто text[i]
    }                          

    return resalt;
}

string newText = RepLace(text, ' ', '|');

Console.WriteLine(newText);
Console.WriteLine();
newText = RepLace(newText, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();
newText = RepLace(newText, 'а', 'А');
Console.WriteLine(newText);
Console.WriteLine();
newText = RepLace(newText, 'о', 'О');
Console.WriteLine(newText);