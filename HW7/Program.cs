// Homework 7
// Task 1.
// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
double[,] CreateRandom2dArray()
{
    Console.Write("Enter number of rows of array ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter number of columns of array ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter min num in array ");
    double minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter max num in array ");
    double maxValue = Convert.ToInt32(Console.ReadLine());
    double range = maxValue - minValue;

    double[,] array = new double[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = Math.Round(new Random().NextDouble() * range + minValue, 1);

    return array;
}

void Print2dArray(double[,] array)
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

// Task 2.
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

void ShowArrayElement(int[,] array, int m, int n)
{
    if (m < 0 
     || n < 0 
     || m >= array.GetLength(0)
     || n >= array.GetLength(1))
        Console.Write($"There is no [{m}, {n}] element in array");
    else
        Console.Write($"Element [{m}, {n}] is {array[m,n]}");
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

int[,] myArray = {{1, 4, 7, 2},
                  {5, 9, 2, 3},
                  {8, 4, 2, 4}};

Console.Write("Enter row of array ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter column of array ");
int columns = Convert.ToInt32(Console.ReadLine());

Print2dArray(myArray);
ShowArrayElement(myArray, rows, columns);


// Task 3.
// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
/*
int[,] CreateRandom2dArray()
{
    Console.Write("Enter rows of array ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter columns of array ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter min num in array ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter max num in array ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);

    return array;
}

double[] GetAverageClumns(int[,] array)
{
    double[] arrayAvg = new double[array.GetLength(1)];
    double current = 0;

    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
            current += array[i, j];
        
        arrayAvg[j] = current / array.GetLength(0);
        current = 0;
    }

    return arrayAvg;
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

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

int[,] myArray = CreateRandom2dArray();

Print2dArray(myArray);
PrintArray(GetAverageClumns(myArray));
*/