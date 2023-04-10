//Напишите программу, которая принимает на вход координаты двух 
//точек и находит расстояние между ними в 2D пространстве.

Console.Clear();

Console.Write("Введите X1: ");
int X1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите Y1: ");
int Y1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите X2: ");
int X2 = int.Parse(Console.ReadLine()!);

Console.Write("Введите Y2: ");
int Y2 = int.Parse(Console.ReadLine()!);

double X = Math.Abs(X1 - X2);
double Y = Math.Abs(Y1 - Y2);

double XX = Math.Pow(X, 2);
double YY = Math.Pow(Y, 2);

double result = Math.Sqrt(XX + YY);

Console.Write($"{result:f2}");