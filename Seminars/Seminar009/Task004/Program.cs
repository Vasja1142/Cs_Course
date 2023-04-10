// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.

int RaicingToPower(int a, int b)
{
    if (b == 0) return 1;
    else
    {
        return a * RaicingToPower(a, b - 1);
    }
}

Console.Clear();

Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine()!);

Console.Write("Введите степень числа: ");
int pow = int.Parse(Console.ReadLine()!);

int result = RaicingToPower(N, pow);
Console.Write(result);
