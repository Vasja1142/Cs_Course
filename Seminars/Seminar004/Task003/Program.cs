// Определить количество цифр в числе

Console.Clear();

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
num = Math.Abs(num);
int a = 0;

for (int i = 1; i <= num; i *= 10)
    a++;
Console.Write(a);

// Console.Clear();
// Console.WriteLine("введите число:");
// int a = int.Parse(Console.ReadLine());
// int numberOfDigits = 0;
// a = Math.Abs(a);
// int i = 1;
// while (i <= a)
// {
// numberOfDigits++;
// i *= 10;
// }
// Console.WriteLine(numberOfDigits);