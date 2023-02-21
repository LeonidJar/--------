// Homework 4
// Task 1. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
int PowerFunc(int a, int b)
{
    int i = 1;

    while (i < b)
    {
        a *= a;

        i++;
    }

    return a;
}

Console.Write("Enter number ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter degree of number ");
int num2 = Convert.ToInt32(Console.ReadLine());

int result = PowerFunc(num1, num2);

Console.WriteLine($"{num1} to power {num2} is {result}");
*/

// Task 2. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
int SumOfDigits(int num)
{
    int digits = 0;
    int digitLeft = 0;
    int current = num;

    if (num == 0) digits = 1;

    while (current != 0)
    {
        current /= 10;
        digits++;
    }

    for (int i = 0; i <= digits; i++)
    {
        digitLeft = num / Convert.ToInt32(Math.Pow(10, digits - i));
        digitLeft = digitLeft % 10;;

        current += digitLeft;
    }

    return current;
}

Console.WriteLine("Enter your number: ");
int num = Convert.ToInt32(Console.ReadLine());

int result = SumOfDigits(num);

Console.WriteLine($"Sum of digitns in {num} is {result}");
*/

// Task 3. Напишите программу, которая задаёт массив из m элементов и выводит их на экран.
/*
int[] GetArray(int size)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        Console.Write($"Enter {i+1} element: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }

    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

Console.Write("Enter size of an array: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] myArray = GetArray(size);
PrintArray(myArray);
*/