// Task 1. Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных элементов массива.
/*
int[] CreateRandomArray()
{
    int[] array = new int[12];

    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-9, 10);

    return array;
}

int NegativSum(int[] array)
{
    int sum = 0;

    for (int i = 0; i < array.Length; i++)
        if (array[i] < 0)
            sum += array[i];

    return sum;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

int[] myArray = CreateRandomArray();
int sum = NegativSum(myArray);

PrintArray(myArray);

Console.Write($"Sum of negative elements is {sum}");
*/

// Task 2. Напишите программу замены элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);

    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

int[] ChanheSign(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] *= -1;

    return array;
}

Console.Write("Enter size of array ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter min num in array ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter max num in array ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(number, min, max);
PrintArray(myArray);

PrintArray(ChanheSign(myArray));
*/

// Task 3. Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);

    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

bool CurrentNumCheck(int[] array, int current)
{
    for (int i = 0; i < array.Length; i++)
        if (array[i] == current)
            return true;

    return false;
}

Console.Write("Enter size of array ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter min num in array ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter max num in array ");
int max = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter your number ");
int current = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(number, min, max);
PrintArray(myArray);

if (CurrentNumCheck(myArray, current)) 
    Console.Write("Your number is in array");
else 
    Console.Write("Your number is not in array");
*/

// Task 4. Задайте одномерный массив из m случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [a,b].
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);

    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

int SegmentCheck(int[] array, int a, int b)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
        if (array[i] >= a && array[i] <= b)
            count += 1;

    return count;
}

Console.Write("Enter size of array ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter min num in array ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter max num in array ");
int max = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter left boundary of the segment ");
int left = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter right boundary of the segment ");
int right = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(number, min, max);
PrintArray(myArray);

int count = SegmentCheck(myArray, left, right);

Console.Write($"There are {count} elements in segment [{left}; {right}]");
*/