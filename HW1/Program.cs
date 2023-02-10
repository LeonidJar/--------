// Homework 1
// Task 1. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
Console.Write("Enter first num: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second num: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 == num2) 
    Console.WriteLine("Nums are equal");
else
{
    if (num1 > num2)
    {
        Console.WriteLine("Max = " + num1);
        Console.WriteLine("Min = " + num2);
    } 
    else
    {
        Console.WriteLine("Max = " + num2);
        Console.WriteLine("Min = " + num1);
    } 
}
*/

// Task 2. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел
/*
Console.WriteLine("Enter three nums");

Console.Write("num 1: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("num 2: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("num 3: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;

if (num2 > max) 
    max = num2;
if (num3 > max) 
    max = num3;

Console.WriteLine("Max = " + max);
*/

// Task 3. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)
/*
Console.Write("Enter num: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0)
    Console.Write("num is even");
else 
    Console.Write("num is odd");
*/

// Task 4. Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N
/*
Console.Write("Enter positive num: ");
int num = Convert.ToInt32(Console.ReadLine());

int current = 2;

while (current <= num)
{
    Console.Write(current + " ");
    current += 2;
}
*/