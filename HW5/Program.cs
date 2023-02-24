// Homework 5
// Task 1. Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
/*
int[] CreateRandomArray(int size)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(100, 1000);

    return array;
}

int EvenCheck(int[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
        if (array[i] % 2 == 0)
            count++;

    return count;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

Console.Write("Enter size of array ");
int number = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(number);
PrintArray(myArray);

int amount = EvenCheck(myArray);
Console.Write($"There are {amount} even elements in array");
*/

// Task 2. Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
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

int OddElementsSum(int[] array)
{
    int sum = 0;

    for (int i = 1; i < array.Length; i += 2)
        sum += array[i];
    
    return sum;
}

Console.Write("Enter size of array ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter min num in array ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter max num in array ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(number, min, max);
PrintArray(myArray);

int sum = OddElementsSum(myArray);
Console.Write($"Sum of odd elements in array is {sum}");
*/

// Task 3. Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
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

int MinMaxDiff(int[] array)
{
    int min = array[0];
    int max = array[0];

    for (int i = 1; i < array.Length; i++)
        if (array[i] < min)
            min = array[i];
        else 
            if (array[i] > max)
                max = array[i];

    return max - min;
}

Console.Write("Enter size of array ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter min num in array ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter max num in array ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(number, min, max);
PrintArray(myArray);

int sum = MinMaxDiff(myArray);
Console.Write($"Difference between max & min value in array is {sum}");
*/