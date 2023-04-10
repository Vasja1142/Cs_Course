//Найти сумму чисел от 1 до А
Console.Clear();

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine()!);
int i = 1;
int result = 0;

while (N >= i)
{
    result = result + i;
    i++;
}

while (i > 1)
{
    i = i - 1;
    result = result + i;
}
Console.Write($"Сумма чисел = {result}");