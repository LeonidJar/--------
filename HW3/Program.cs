//Homework 3
//Task 1. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//ver 1
/*
bool PalyndromeCheck(int num)
{
    int digits = 0;
    int digitRight = 0;
    int digitLeft = 0;

    while ((num / Convert.ToInt32(Math.Pow(10, digits))) != 0)
    {
        digits++;
    }

    for (int i = 1; i <= digits / 2; i++)
    {
        digitRight = num % Convert.ToInt32(Math.Pow(10, i));
        digitRight = digitRight / Convert.ToInt32(Math.Pow(10, i - 1));

        digitLeft = num / Convert.ToInt32(Math.Pow(10, digits - i));
        digitLeft = digitLeft % 10;

        if (digitRight != digitLeft)
                return false;
    }

    return true;
}

Console.WriteLine("Enter your number: ");
int num = Convert.ToInt32(Console.ReadLine());

if (PalyndromeCheck(num))
    Console.WriteLine($"{num} is palyndrome");
else 
    Console.WriteLine($"{num} is not palyndrome");
*/

//ver 2
/*
bool PalyndromeCheck(string num)
{
    for (int i = 0; i < num.Length / 2; i++)
    {
        if (num[num.Length - 1 - i] != num[i])
            return false;
    }

    return true;
}

Console.WriteLine("Enter your number: ");
string num = Console.ReadLine();

if (PalyndromeCheck(num))
    Console.WriteLine($"{num} is palyndrome");
else 
    Console.WriteLine($"{num} is not palyndrome");
*/

//Task 2. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//ver 1
/*
double Distance(double xA, double yA, double zA, double xB, double yB, double zB)
{
    double distanceSqr = Math.Pow(xA - xB, 2) + Math.Pow(yA - yB, 2) + Math.Pow(zA - zB, 2);

    return Math.Sqrt(distanceSqr);
}

Console.WriteLine("Enter first point coordinate X: ");
double pointAX = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter first point coordinate Y: ");
double pointAY = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter first point coordinate Z: ");
double pointAZ = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter second point coordinate X: ");
double pointBX = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter second point coordinate Y: ");
double pointBY = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter second point coordinate Z: ");
double pointBZ = Convert.ToDouble(Console.ReadLine());

double length = Distance(pointAX, pointAY, pointAZ, pointBX, pointBY, pointBZ);

Console.WriteLine($"Distance between point A({pointAX}; {pointAY}; {pointAZ}) & point B({pointBX}; {pointBY}; {pointBZ}) is {length}");
*/

//ver 2
/*
double Distance(double[] pA, double[] pB)
{
    double distanceSqr = 0;

    for (int i = 0; i < 3; i++)
    {
        distanceSqr += Math.Pow(pA[i] - pB[i], 2);
    }

    return Math.Sqrt(distanceSqr);
}

double[] pointA = new double[3];
double[] pointB = new double[3];

Console.WriteLine("Enter first point coordinate X: ");
pointA[0] = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter first point coordinate Y: ");
pointA[1] = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter first point coordinate Z: ");
pointA[2] = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter second point coordinate X: ");
pointB[0] = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter second point coordinate Y: ");
pointB[1] = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter second point coordinate Z: ");
pointB[2] = Convert.ToDouble(Console.ReadLine());

double length = Distance(pointA, pointB);

Console.WriteLine($"Distance between point A({pointA[0]}; {pointA[1]}; {pointA[2]}) & point B({pointB[0]}; {pointB[1]}; {pointB[2]}) is {length}");
*/

//Task 3. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*
void TablePrint(int num)
{
    int current = 1;

    while (current <= num)
    {
        Console.WriteLine(current + " " + (current * current * current));
        current++;
    }
}

Console.WriteLine("Enter your number: ");
int number = Convert.ToInt32(Console.ReadLine());

TablePrint(number);
*/