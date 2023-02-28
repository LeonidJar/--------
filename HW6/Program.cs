//Homwork 6
// Task 1. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*
void PositiveCounter(int amount)
{
    int result = 0;

    for (int i = 1; i <= amount; i++)
        if (Convert.ToInt32(Console.ReadLine()) > 0)
            result++;

    Console.WriteLine($"There are {result} positive numbers u written");
}

Console.Write("Enter how many numbers u want ");
int amount = Convert.ToInt32(Console.ReadLine());

if (amount <= 0)
    Console.Write($"U can't write {amount} numbers");
else
    PositiveCounter(amount);
*/

// Task 2. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
/*
void LineCrossing(double a1, double b1, double a2, double b2)
{
    if (a1 == a2)
        if (b1 == b2)
            Console.WriteLine("Lines match");     
        else
            Console.WriteLine("Lines are parallel"); 
    else
    {
        double x = (b2 - b1) / (a1 - a2);
        double y = a1 * x + b1;

        Console.WriteLine($"Point of intersection of lines is [{x}; {y}]");
    }
}

Console.WriteLine("Enter the parameters k1 and k2 of the first line");
Console.Write("k1 = "); 
int k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("k2 = "); 
int k2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the parameters k1 and k2 of the second line");
Console.Write("k1 = "); 
int k3 = Convert.ToInt32(Console.ReadLine());
Console.Write("k2 = "); 
int k4 = Convert.ToInt32(Console.ReadLine());

LineCrossing(k1, k2, k3, k4);
*/