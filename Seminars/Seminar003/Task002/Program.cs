//Напишите программу, которая по заданному номеру четверти, 
//показывает диапазон возможных координат точек в этой четверти 
//(x и y).

Console.Clear();

Console.Write("Введите четверть: ");
int quarter = int.Parse(Console.ReadLine()!);

if (quarter == 1)
{
    Console.Write("X > 0, Y > 0");
}
else if (quarter == 2)
{
    Console.Write("X < 0, Y > 0");
}
else if (quarter == 3)
{
    Console.Write("X < 0, Y < 0");
}
else if (quarter == 4)
{
    Console.Write("X > 0, Y < 0");
}
else
{
    Console.Write("Нет такой четверти");
}

switch (quarter)
{
    case 1:
        Console.Write("X > 0, Y > 0");
        break;
    case 2:
        Console.Write("X < 0, Y > 0");
        break;
    case 3:
        Console.Write("X > 0, Y > 0");
        break;
    case 4:
        Console.Write("X > 0, Y < 0");
        break;
    default:
        Console.Write("Нет такой четверти");
        break;
}