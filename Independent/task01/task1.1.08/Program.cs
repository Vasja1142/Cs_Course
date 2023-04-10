// 1.1.8. Дано натуральное n, вычислите n!

Console.Write("Введите натуральное число n: ");
int n = int.Parse(Console.ReadLine()!);
int result = 1;
for (int i = 2; i <= n; i++)
{
    result *= i;
}

Console.Write($"{n}! = {result}");