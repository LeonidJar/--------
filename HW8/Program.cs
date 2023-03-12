// Task 1
// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
/*
void RowSort(int[,] array) 
{
    for (int k = 0; k < array.GetLength(1); k++)
        for (int i = 0; i < array.GetLength(0); i++)
            for (int j = 1; j < array.GetLength(1); j++)
                if (array [i, j] > array[i, j - 1])
                    {
                        int temp = array[i, j];
                        array[i, j] = array[i, j - 1];
                        array[i, j - 1] = temp;
                    }
}

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
RowSort(myArray);
Print2dArray(myArray);
*/

// Task 2
// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
/*
void MinSumInRow(int[,] array)
{
    int sum = 0;
    int minRow = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        int rowSum = 0;

        for (int j = 0; j < array.GetLength(1); j++)
            rowSum += array[i, j];
        
        if (i == 0)
            sum = rowSum;

        if (rowSum < sum)
        {
            sum = rowSum;
            minRow = i;
        }    
    }

    Console.WriteLine($"Min summ in rows is {minRow + 1}");
}

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
MinSumInRow(myArray);
*/

// Task 3
// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
/*
void ArrayMultiply(int[,] arrayA, int[,] arrayB)
{
    if (arrayA.GetLength(1) == arrayB.GetLength(0))
    {
        int[,] result = new int[arrayA.GetLength(0), arrayB.GetLength(1)];
        int sum = 0;

        for (int i = 0; i < arrayA.GetLength(0); i++)
            for (int j = 0; j < arrayB.GetLength(1); j++)
                for (int k = 0; k < arrayB.GetLength(0); k++)
                    result[i,j] += arrayA[i,k] * arrayB[k,j];    

         Print2dArray(result);            
    }
    else
        Console.WriteLine("Arrays cant be multiplyed");
}

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

Console.WriteLine("Enter the parameters of the first array");
int[,] AArray = CreateRandom2dArray();
Console.WriteLine("Enter the parameters of the second array");
int[,] BArray = CreateRandom2dArray();

Print2dArray(AArray);
Print2dArray(BArray);
ArrayMultiply(AArray, BArray);
*/

// Task 4
// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
/*
int[,,] CreateRandom3dArrayNoEqual()
{
    Console.Write("Enter width of array ");
    int width = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter height of array ");
    int height = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter depth of array ");
    int depth = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter min num in array ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter max num in array ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    if (maxValue - minValue + 1 >= width * height * depth)
    {
        int[,,] array = new int[width, height, depth];

        for (int i = 0; i < width; i++)
            for (int j = 0; j < height; j++)
                for (int k = 0; k < depth; k++)
                {
                    int current = new Random().Next(minValue, maxValue + 1);

                    if (!EqualCheck(current, array))
                        k--;
                    else
                        array[i, j, k] = current;
                }

        return array;
    }
    else 
        return null;
}

bool EqualCheck(int num, int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            for (int k = 0; k < array.GetLength(2); k++)
                if (array[i, j , k] == num)
                    return false;
    
    return true;
}

void Print3dArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
                Console.Write($"{array[i, j, k]}({i}, {j}, {k}) ");
        Console.WriteLine();
        }

    Console.WriteLine();
}

int[,,] newArray = CreateRandom3dArrayNoEqual();

if (newArray == null)
    Console.WriteLine("Cant create array this size with unique elements");
else
    Print3dArray(newArray);
*/

// Task 5
// Напишите программу, которая заполнит спирально массив 4 на 4. 

int[,] SpiralFillingArray(int rows, int cols)
{
    int[,] array = new int[rows, cols];
    int current = 1;
    int i = 0;
    int j = 0;
    int index = 0;
    int[] target = {0, cols};

    while (current <= rows * cols)
    {
        for (; j < target[1]; j++)
        {
            array[i, j] = current;
            current++;
        }
        target[0] = rows - index;
        i++;
        j--;

        for (; i < target[0]; i++)
        {
            array[i, j] = current;
            current++;
        }
        target[1] = index;
        j--;
        i--;
        index++;

        for (; j >= target[1]; j--)
        {
            array[i, j] = current;
            current++;
        }
        target[0] = index;
        i--;
        j++;

        for (; i >= target[0]; i--)
        {
            array[i, j] = current;
            current++;
        }
        target[1] = cols - index;
        j++;
        i++;
    }
    
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

Console.Write("Enter rows of array ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter columns of array ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] newArray = SpiralFillingArray(rows, columns);
Print2dArray(newArray);