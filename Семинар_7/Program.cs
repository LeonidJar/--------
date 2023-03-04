// Task 1. Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
/*
int[,] CreateRandom2dArray()
{
    Console.Write("Enter raws of array ");
    int raws = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter columns of array ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter min num in array ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter max num in array ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[raws, columns];

    for (int i = 0; i < raws; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);

    return array;
}

void Print2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
    Console.WriteLine();
    }

    Console.WriteLine();
}

Print2dArray(CreateRandom2dArray());
*/

// Task 2. Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aij = i + j. Выведите полученный массив на экран.
/*
int[,] FunctionArray(int m, int n)
{
    int[,] array = new int[m, n];

    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
            array[i, j] = i + j;

    return array;
}

void Print2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
    Console.WriteLine();
    }

    Console.WriteLine();
}

Console.Write("Enter raws of array ");
int raws = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter columns of array ");
int columns = Convert.ToInt32(Console.ReadLine());

Print2dArray(FunctionArray(raws, columns));
*/

// Task 3. Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
/*
int[,] CreateRandom2dArray()
{
    Console.Write("Enter raws of array ");
    int raws = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter columns of array ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter min num in array ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter max num in array ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[raws, columns];

    for (int i = 0; i < raws; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);

    return array;
}

int[,] EvenIndexSqr(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i += 2)
        for (int j = 0; j < array.GetLength(0); j += 2)
            array[i, j] *= array[i, j];

    return array;
}

void Print2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
    Console.WriteLine();
    }

    Console.WriteLine();
}

int[,] myArray = CreateRandom2dArray();

Print2dArray(myArray);
Print2dArray(EvenIndexSqr(myArray));
*/

// Task 4. Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

int[,] CreateRandom2dArray()
{
    Console.Write("Enter raws of array ");
    int raws = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter columns of array ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter min num in array ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter max num in array ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[raws, columns];

    for (int i = 0; i < raws; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);

    return array;
}

int MainDiagonalSum(int[,] array)
{
    int sum = 0;

    for (int i = 0; i < array.GetLength(0) && i < array.GetLength(1); i++)
        sum += array[i, i];

    return sum;
}

void Print2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
    Console.WriteLine();
    }

    Console.WriteLine();
}

int[,] myArray = CreateRandom2dArray();

Print2dArray(myArray);
Console.Write($"Sum of elements on main diagonal is {MainDiagonalSum(myArray)}");