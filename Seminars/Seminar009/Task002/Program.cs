// Задача 65: Задайте значение M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

string Recurs(int N, int M)
{
    if (N <= M) return N.ToString();
    else return Recurs(N - 1, M) + ", " + N.ToString();
}

Console.Clear();

Console.Write("Введите число M: ");
int M = int.Parse(Console.ReadLine()!);
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);

Console.Write(Recurs(N, M));
