﻿//Задача 2: Напишите программу, которая на вход принимает два числа 
//и выдает, какое число большее, а какое меньшее.

Console.Clear();

Console.Write("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine()!);

if (num1 > num2)
{
    Console.WriteLine($"Число {num1} больше {num2}");
}
else 
    if (num1 < num2)
    {
        Console.WriteLine($"Число {num2} больше {num1}");
    }
    else
    {   
        Console.WriteLine("Числa равныe");
    }