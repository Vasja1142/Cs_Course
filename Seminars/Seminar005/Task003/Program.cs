// Задача 33: Задайте массив. Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве.

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}


bool FinlNumber (int[] inArray, int number)
{
    foreach (int element in inArray)
    {
        if (element == number)
        return true;
    }
    return false;

}

Console.Clear();

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
int[] array = GetArray(20, -10, 10);


Console.WriteLine($"Массив: {String.Join(", ", array)}");

if (FinlNumber(array, num) == true)
{
    Console.WriteLine("Данное число присутствует в массиве");
}
else
{
    Console.WriteLine("Данного числа нет в массиве");
}

