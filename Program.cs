// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
/*
Console.Write("Input number and I show you sequens from your number to <1> ");
void ShowNumbers(int n)
{
    Console.Write($"{n}="); if (n > 1)  ShowNumbers(n - 1);
}
Console.Write("Input number : ");
int num = Convert.ToInt32(Console.ReadLine());
ShowNumbers(num);
*/

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30  Math.Max(n,m)
/*
int SumNumbersMN(int n, int m, int sum)
{
    if (m >= n)
    {
        sum = m + SumNumbersMN(n, m - 1, sum);
        return sum;
    }
    else
        return 0;
}
Console.Write("Input first number : ");
int firstNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Input secound number : ");
int secoundNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SumNumbersMN(Math.Min(firstNum,secoundNum), Math.Max(firstNum,secoundNum),0));
*/

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


int AccerMan(int m, int n)
{
    if (m == 0) return n + 1;
    if (m != 0 && n == 0) return AccerMan(m - 1, 1);
    return AccerMan(m - 1, AccerMan(m, n - 1));
}

Console.WriteLine("Я не знаю кто такой Аккерман, но он вернет тебе число в ответ на твои два");
Console.Write("Введите <M> : ");
int numM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите <N> : ");
int numN = Convert.ToInt32(Console.ReadLine());
Console.Write($"А это тебе: <{AccerMan(numM, numN)}> ");
