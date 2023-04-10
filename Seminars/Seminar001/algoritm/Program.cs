Console.Clear();

Console.WriteLine("Введите трехзначное число: ");

int num;
num = int.Parse(Console.ReadLine()!);

int B = num / 10;

int num1 = num - B * 10;

Console.Write($"{num1} ");
