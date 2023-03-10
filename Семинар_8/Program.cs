// Task 1
// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива. (Любые 2 строки массива)
/*
void ChangeRows(int[,] array, int row1, int row2)
{
    if (row1 >= 0 && row1 < array.GetLength(0) &&
        row2 >= 0 && row2 < array.GetLength(0) &&
        row1 != row2)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int temp = array[row1, j];
            array[row1, j] = array[row2, j];
            array[row2, j] = temp;
        }
    }
}

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

int[,] myArray = CreateRandom2dArray();

Console.Write("Enter first row of array ");
int rowF = Convert.ToInt32(Console.ReadLine()) - 1;
Console.Write("Enter second row of array ");
int rowS = Convert.ToInt32(Console.ReadLine()) - 1;

Print2dArray(myArray);
ChangeRows(myArray, rowF, rowS);
Print2dArray(myArray);
*/

// Task 2
// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
/*
void TransponseArray(int[,] array)
{
    if (array.GetLength(0) == array.GetLength(1))
    {
        for (int i = 0; i < array.GetLength(0); i++)
            for (int j = i; j < array.GetLength(1); j++)
                {
                    int temp = array[i, j];
                    array[i, j] = array[j, i];
                    array[j, i] = temp;
                }
    }
    else 
        Console.WriteLine("Unable to transpose array");
}

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

int[,] myArray = CreateRandom2dArray();

Print2dArray(myArray);
TransponseArray(myArray);
Print2dArray(myArray);
*/

// Task 3
// Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент.

int[] FindMinElementPos(int[,] array)
{
    int min = array[0, 0];
    int[] minPos = new int[2];
 
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            if (array[minPos[0], minPos[1]] > array[i, j])
            {
                minPos[0] = i;
                minPos[1] = j;
            }

    return minPos;
}

int[,] RemoveRowAndColumn(int[,] array, int row, int col)
{
    int[,] result = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];

        for (int i = 0, newI = 0; i < array.GetLength(0); i++)
            if (i != row)
            {
                for (int j = 0, newJ = 0; j < array.GetLength(1); j++)
                if (j != col)
                {
                    result[newI, newJ] = array[i, j];
                    newJ++;
                }
                newI++;
            }
           
       
    return result;
}

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

int[,] array = CreateRandom2dArray();
Print2dArray(array);

int[] minPosition = FindMinElementPos(array);

int[,] newAray = RemoveRowAndColumn(array, minPosition[0], minPosition[1]);

Print2dArray(newAray);