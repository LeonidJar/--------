int CutNumber(int num)
{
    int result = (num / 100) * 10 + num % 10;
    return result;
}

int num = new Random().Next(100, 1000);

Console.WriteLine(num);
Console.WriteLine(CutNumber(num));