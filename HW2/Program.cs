// Homework 2
// Task 1. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
int SecondDigit(int num)
{
    return (num / 10) % 10;
}

int randNum = new Random().Next(100, 1000);
int secondDig = SecondDigit(randNum);

Console.WriteLine($"Second digit in number {randNum} is {secondDig}");
*/

// Task 2. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
int ThirdDigit(int num)
{
    if (num / 100 == 0) 
        return -1;
    else
    {
        while (num > 1000)
        {
            num = num / 10;
        }

        return num % 10;
    }
}

Console.Write("Enter ur number: ");
int num = Convert.ToInt32(Console.ReadLine());
int thirdDig = ThirdDigit(num);

if (thirdDig == -1)
    Console.WriteLine("There are less then thee digits in ur number");
else
    Console.WriteLine($"Third digit in ur number {num} is {thirdDig}");
*/

// Task 3. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
/*
bool IsWeekEnd(int num)
{
    return num == 6 || num == 7;
}

Console.Write("Enter a number of day in week: ");
int dayNum = Convert.ToInt32(Console.ReadLine());

if (dayNum > 7 || dayNum < 1)
    Console.WriteLine($"There is no {dayNum} day in week");
else
    if (IsWeekEnd(dayNum))
        Console.WriteLine($"{dayNum} day of the week is weekend");
    else
        Console.WriteLine($"{dayNum} day of the week is not weekend");
*/