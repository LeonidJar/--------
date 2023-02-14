/*
int CutNumber(int num)
{
    int hundreds = num / 100;
    int units = num % 10;
    int result = hundreds * 10 + units;

    return result;
}

int randNum = new Random().Next(100, 1000);

int newNum = CutNumber(randNum);

Console.WriteLine($"New ver of {randNum} is {newNum}");
*/

//Task 2. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно a и b.
/*
bool CheckNum(int num, int div1, int div2)
{
    // if (num % div1 * div2 == 0)
    if (num % div1 == 0 && num % div2 == 0)
        return true;
    else 
        return false;
    // return num % div1 * div2 == 0;
}

Console.Write("Enter num: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter div1: ");
int div1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter div2: ");
int div2 = Convert.ToInt32(Console.ReadLine());

bool result = CheckNum(num, div1, div2);

if (result)
    Console.WriteLine($"{num} can be divided by {div1} & {div2}");
else
    Console.WriteLine($"{num} can not be divided by {div1} & {div2}");
*/

//Task 3. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
/*
int MaxDigit(int num)
{
    int dozens = num / 10;
    int units = num % 10;
    if (dozens > units)
        return dozens;
    else
        return units;
}

int randNum = new Random().Next(10, 100);

int maxDigit = MaxDigit(randNum);

Console.WriteLine($"Max digit in number {randNum} is {maxDigit}");
*/

//Task 4. Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
/*
bool IsSqr(int num1, int num2)
{
    return num1 * num1 == num2 || num1 == num2 * num2;
}

Console.Write("Enter num1: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter num2: ");
int num2 = Convert.ToInt32(Console.ReadLine());

bool check = IsSqr(num1, num2);

if (check)
    Console.WriteLine("one num is sqr of other");
else
    Console.WriteLine("one num is NOT sqr of other");
*/