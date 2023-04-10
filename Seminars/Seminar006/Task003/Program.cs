// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.

Console.Clear();

Console.Write("Введите любое число: ");
int number = Convert.ToInt32(Console.ReadLine()!);

void WriteFibonacci(int num)
{
    double a = 0;
    double b = 1;

    if (num >= 1) Console.WriteLine($"n1 = 0");
    if (num >= 2) Console.WriteLine($"n2 = 1");


    for (int i = 3; i <= num; i++)
    {
        if(i % 2 != 0)
        {
            a += b;
            Console.WriteLine($"n{i} = {a}");
        }
        else
        {
            b += a;
            Console.WriteLine($"n{i} = {b}");
        }
    }
}

WriteFibonacci(number);