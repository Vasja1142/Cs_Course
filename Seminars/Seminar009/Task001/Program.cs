// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.

string Recurs(int N)
{
    if (N == 1) return N.ToString();
    else return Recurs(N - 1) + ", " + N.ToString();
}

Console.Clear();

Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);
Console.Write(Recurs(N));