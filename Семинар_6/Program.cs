// Task 1. Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
/*
void ElementSawap(int[] array)
{
    for (int i = 0, j = array.Length - 1; i < j; i++, j--)
    {
        int current = array[i];
        array[i] = array[j];
        array[j] = current;
    }
} 

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

Console.Write("Enter size of array ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter min num in array ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter max num in array ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(number, min, max);
PrintArray(myArray);
ElementSawap(myArray);

PrintArray(myArray);
*/

// Task 2. Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
/*
bool TriangleCheck(int a, int b, int c)
{
    return a < b + c && b < a + c && c < a + b;
}

Console.WriteLine("Enter sides of the triangle");
Console.Write("a = ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("b = ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("c = ");
int c = Convert.ToInt32(Console.ReadLine());

if (TriangleCheck(a, b, c))
    Console.Write("Triangle exist");
else 
    Console.Write("Triangle does not exist");
*/

// Task 3. Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: a и b.
/*
int[] Fibonacci(int size, int a, int b)
{
    int[] array = new int[size];
    array[0] = a;
    array[1] = b;

    for (int i = 2; i < size; i++)
        array[i] = array[i - 1] + array[i - 2];

    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

Console.Write("Enter amount ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter first Fibbonachi num ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second Fibbonachi num ");
int b = Convert.ToInt32(Console.ReadLine());

PrintArray(Fibonacci(size, a, b));
*/

// Task 4. Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
/*
int[] ArrayCopy(int[] array)
{
    int[] myArray = new int[array.Length];

    for (int i = 0; i < array.Length; i++)
        myArray[i] = array[i];

    return myArray;
}

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

Console.Write("Enter size of array ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter min num in array ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter max num in array ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(number, min, max);
PrintArray(myArray);
Console.WriteLine();
PrintArray(ArrayCopy(myArray));
*/

// Task 5. Напишите программу, которая будет преобразовывать десятичное число в двоичное.

string ConvertToBin(int number)
{
    string res = String.Empty;

    while (number > 0)
    {
        res = number % 2 + res;
        number = number / 2; 
    }

    return res;
}

Console.Write("Input dec number: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(ConvertToBin(number));
