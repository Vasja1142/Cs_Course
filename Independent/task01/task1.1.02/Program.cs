// Решите предыдущую задачу, не используя дополнительных
// переменных (и предполагая, что значениями целых переменных могут
// быть произвольные целые числа).

Console.Clear();

Console.Write("Введите первую переменную: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите вторую переменную: ");
int b = int.Parse(Console.ReadLine()!);

a = a + b;
b = a - b;
a = a - b;

Console.WriteLine($"первая переменная: {a}");
Console.WriteLine($"вторая переменная: {b}");