// Собрать строку с числами от а до b, а <= b

// 1 Правило, нужно понимать, когда рукурсия должна остановиться

// string NambersFor(int a, int b)
// {
//     string result = String.Empty;
//     for (int i = a; i <= b; i++)
//     {
//         result += $"{i} ";
//     }
//     return result;
// }

string NambersRec(int a, int b)
{
    if(a<=b) return $"{a} " + NambersRec(a+1, b);
    else return String.Empty;
}

//Console.WriteLine(NambersFor(1, 10));//1 2 3 4 5 6 7 8 9 10 
Console.WriteLine(NambersRec(1, 10));//1 2 3 4 5 6 7 8 9 10 

