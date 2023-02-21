// Task 1. Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
/*
int GetSum(int num)
{
    int sum = 0;

    for (int current = 1; current <= num; current++)
    {
        sum += current;
    }

    return sum;
}

Console.WriteLine("Enter your number ");
int num = Convert.ToInt32(Console.ReadLine());

int result = GetSum(num);

Console.WriteLine($"Summ of numbers from 1 to {num} is {result}");
*/

// Task 2. Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
/*
int Digits(int num)
{
    int digits = 0;

    if (num == 0) digits = 1;

    while (num != 0)
    {
        num /= 10;
        digits++;
    }

    return digits;
}

Console.Write("Enter your number ");
int number = Convert.ToInt32(Console.ReadLine());

int dig = Digits(number);

Console.WriteLine($"There are {dig} digits in {number}");
*/

// Task 3. Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
/*
int Factorial(int num)
{
    int result = 1;

    for (int current = 1; current <= num; current++)
    {
        result *= current;
    }

    return result;
}

Console.Write("Enter your number ");
int number = Convert.ToInt32(Console.ReadLine());

int result = Factorial(number);

Console.WriteLine($"Factorial of number {number} is {result}");
*/
/*
// Заполнение массива  случайными числами

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);

    return array;
}

// Вывод массива

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

Console.Write("Enter size of array ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter min num in array ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter max num in array ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(number, min, max);
PrintArray(myArray);
*/