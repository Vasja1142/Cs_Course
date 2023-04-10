// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.


int SumNumbers(int N)
{
    if (N == 0)
    {
        return 0;
    } 
    else
    {
        return N % 10 + SumNumbers(N / 10);
    }
}

Console.Clear();

Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);
Console.Write(SumNumbers(N));