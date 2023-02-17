// Task 1. Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
/*
void ShowDiapozone(int quad)
{
    if (quad == 1) Console.WriteLine("x > 0 and y > 0");
    else if (quad == 2) Console.WriteLine("x < 0 and y > 0");
    else if (quad == 3) Console.WriteLine("x < 0 and y < 0");
    else if (quad == 4) Console.WriteLine("x > 0 and y < 0");
    else Console.WriteLine("Incorrect input");

}

Console.WriteLine("Enter a number of quadrant");
int quadrant = Convert.ToInt32(Console.ReadLine());

ShowDiapozone(quadrant);
*/

// Task 2. Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
/*
int QuadDeterm(int x, int y)
{
    int quad = 0;

    if (x > 0 && y > 0) quad = 1;
    else if (x < 0 && y > 0) quad = 2;
    else if (x < 0 && y < 0) quad = 3;
    else if (x > 0 && y < 0) quad = 4;

    return quad;
}

Console.WriteLine("Enter point coordinate X: ");
int pointX = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter point coordinate Y: ");
int pointY = Convert.ToInt32(Console.ReadLine());

int quad = QuadDeterm(pointX, pointY);

Console.WriteLine($"Point with coordinates ({pointX}:{pointY}) is in {quad} quadrant");
*/

// Task 3. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
/*
double Distance(double xA, double yA, double xB, double yB)
{
    double hypotenuse = Math.Sqrt(Math.Pow(xA - xB, 2) + Math.Pow(yA - yB, 2));

    return hypotenuse;
}

Console.WriteLine("Enter first point coordinate X: ");
double pointAX = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter first point coordinate Y: ");
double pointAY = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter second point coordinate X: ");
double pointBX = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter second point coordinate Y: ");
double pointBY = Convert.ToDouble(Console.ReadLine());

double length = Distance(pointAX, pointAY, pointBX, pointBY);

Console.WriteLine($"Distance between point A({pointAX}:{pointAY}) & point B({pointBX}:{pointBY}) is {length}");
*/

// Task 4. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
/*
void TablePrint(int num)
{
    int current = 1;

    while (current <= num)
    {
        Console.WriteLine(current + " " + (current * current));
        current++;
    }
}

Console.WriteLine("Enter your number: ");
int number = Convert.ToInt32(Console.ReadLine());

TablePrint(number);
*/