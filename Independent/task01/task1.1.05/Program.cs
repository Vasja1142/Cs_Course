// 1.1.5. Даны натуральные числа а, b. Вычислите произведение a · b,
// используя в программе лишь операции +, -, =, <>.

Console.Clear();

Console.Write("Введите переменную a: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите переменную b: ");
int b = int.Parse(Console.ReadLine()!);
int result = 0;
for (int i = 1; i <= b; i++)
{
    result += a;
}

Console.Write($"{a} x {b} = {result}");