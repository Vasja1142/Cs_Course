// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.

Console.Clear();

Console.Write("Введите десятичное число: ");
int num = Convert.ToInt32(Console.ReadLine()!);

int Conversion(int dec)
{
    int bin = 0;
    int i = 1;
    while (dec >= 2)
    {
        bin += dec % 2 * i;
        dec /= 2;
        i *= 10;
    }
    bin += dec * i;
    return bin;
}

Console.Write($"Двоичное число = {Conversion(num)}");