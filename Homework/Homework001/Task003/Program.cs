﻿//Задача 6: Напишите программу, которая на вход принимает число 
//и выдает, является ли число четным 
//(делится ли оно на два без остатка).

Console.Clear();

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);

if (num % 2 == 0)
{
    Console.Write("Число четное");
}
else
{
    Console.Write("Число нечетное");
}