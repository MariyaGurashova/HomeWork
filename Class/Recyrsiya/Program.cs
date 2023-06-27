// Рекурсия это использование метода внутри метода

// Вычисление факториала

// double Factorial(int n)//double т.к. 17! не вмещается в int, выдает отрицательные значения
// {
//     // 1! = 1
//     // 0! = 1
//     if (n == 1) return 1;
//     else return n * Factorial(n - 1);// n(число)*на факториал предыдущего числа
// }
// for (int i = 1; i <= 40; i++) //3! = 1*2*3
// {
//     Console.WriteLine($"{i}! = {Factorial(i)}");//"!" - принудительно, работает и без него))
// }


// Число Фибоначи

// f(1) = 1
// f(2) = 1
// f(n) = f(n-1) + f(n-2)// 1 - первое число, 2 - второе число

double Fibonacci(int n)
{
    if(n==1 || n==2) return 1;
    else return Fibonacci(n-1) + Fibonacci(n-2);
}

for (int i = 1; i < 40; i++)
{
    Console.WriteLine($"{i}! = {Fibonacci(i)}");
}