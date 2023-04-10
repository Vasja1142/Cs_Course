// 1.1.6. Даны натуральные числа а и b. Вычислите их сумму а + b.
// Используйте операторы присваивания лишь вида
// ⟨переменная1⟩ := ⟨переменная2⟩,
// ⟨переменная⟩ := ⟨число⟩,
// ⟨переменная1⟩ := ⟨переменная2⟩ + 1

Console.Clear();

Console.Write("Введите переменную a: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите переменную b: ");
int b = int.Parse(Console.ReadLine()!);
int result = a;
for (int i = 1; i <= b; i++)
{
    result++;
}
Console.Write($"{a} + {b} = {result}");