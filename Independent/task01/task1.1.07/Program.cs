// 1.1.7. Дано натуральное (целое неотрицательное) число а и целое
// положительное число d. Вычислите частное q и остаток r при делении а
// на d, не используя операций div и mod.

Console.Write("Введите натуральное число а: ");
int a = int.Parse(Console.ReadLine()!); // 9 / 2 = 4 , 1
Console.Write("Введите целое положительное число d: ");
int d = int.Parse(Console.ReadLine()!);
int r = a;
int q = 0;
while (r >= d)
{
    r -= d;
    q++;
} 

Console.Write($"{a} / {d} = {q}, остаток: {r}");