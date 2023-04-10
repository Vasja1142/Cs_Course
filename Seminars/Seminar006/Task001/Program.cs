// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон

Console.Clear();

Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine()!);

Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine()!);

Console.Write("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine()!);

if (a + b > c & b + c > a & c + a > b) Console.WriteLine("Из данных сторон может состоять треугольник");
else Console.WriteLine("Из данных сторон нельзя построить треугольник");
