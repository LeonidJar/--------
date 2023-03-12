// Task 1
// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
/*
void ShowNums(int num)
{
    if (num > 1) ShowNums(num - 1);
    
    Console.Write(num + " ");
}

ShowNums(5);
*/

// Task 2
// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
/*
int DigitsSum(int num)
{
    if (num / 10 != 0) return DigitsSum(num / 10) + Math.Abs(num % 10);
    return Math.Abs(num);
}

Console.Write(DigitsSum(-1234));
*/

//Task 3
// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
/*
void ShowNums(int m, int n)
{
    if (n > m) ShowNums(m, n - 1);

    if (n < m) ShowNums(m, n + 1);

    Console.Write(n + " ");
}

Console.Write("Enter first num ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second num ");
int n = Convert.ToInt32(Console.ReadLine());

ShowNums(m, n);
*/

// Task 4
// Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B.
/*
double APowerB(double a, int b)
{
    if (b > 0) 
        if (b != 1) return APowerB(a, b - 1) * a;

    if (b <= 0)
        if (b != 1) return APowerB(a, b + 1) / a;

    return a;
}

Console.Write("Enter number ");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter power of number ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write(APowerB(a, b));
*/