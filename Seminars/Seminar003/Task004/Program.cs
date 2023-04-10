//Напишите программу, которая принимает на вход число (N) 
//и выдаёт таблицу квадратов чисел от 1 до N.

Console.Clear();

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine()!);
int count = 1;

while (count <= N)
{
    Console.Write(count * count);
    if (count != N)
    {
        Console.Write(", ");
    }
    count++;
}