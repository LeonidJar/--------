// Homework 9
// Task 1
// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
/*
void ShowNums(int n)
{
    Console.Write(n + " ");

    if (n > 1) ShowNums(n - 1);
}

Console.Write("Enter number ");
int num = Convert.ToInt32(Console.ReadLine());
ShowNums(num);
*/

// Task 2
// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
/*
int SumBetween(int m, int n)
{
    if (n > m) return SumBetween(m, n - 1) + n;

    if (n < m) return SumBetween(m, n + 1) + n;

    return n;
}

Console.Write("Enter first num ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second num ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write(SumBetween(m, n));
*/

// Task 3
// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
/*
int AckermanFunc(int m, int n)
{
    while (m != 0)
    {
        if (n == 0)
            n = 1;
        else 
            n = AckermanFunc(m, n - 1);
        m -= 1;
    }
    return n + 1;
}

Console.Write("Enter parameter m ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter parameter n ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write($"m = {m}, n = {n} -> A(m,n) = {AckermanFunc(m, n)}");
*/