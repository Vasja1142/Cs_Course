﻿//Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Clear();

Console.Write("Введите любое положительное число кроме 0: ");
int num = int.Parse(Console.ReadLine()!);
if (num > 0)
{
    int count = 1;
    while (count <= num)
    {
        double result = Math.Pow(count, 3);
        Console.WriteLine($"{count}^3 = {result}");
        count++;
    }
}
else
{
    Console.Write("Пожалуйста, введите число больше 0");
}
