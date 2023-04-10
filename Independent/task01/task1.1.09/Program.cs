// 1.1.9. Последовательность Фибоначчи определяется так: a0 = 0,
// a1 = 1, ak = ak-1 + ak-2 при k > 2. Дано n, вычислите an. 

Console.Clear();

Console.Write("Введите натуральное число n: ");
int n = int.Parse(Console.ReadLine()!);

double a = 0;
double b = 1;

for (int i = 2; i < n; i++)
{
    if (i % 2 == 0) a += b;
    else b += a;
}
double result = 0;

if (n % 2 == 0) {result = b;}
else {result = a;}

Console.Write($"Ответ: {result}");