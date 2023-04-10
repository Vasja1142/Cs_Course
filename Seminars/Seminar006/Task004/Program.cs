// Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}

int[] ArrayCopy(int[] arr)
{
    int[] copy = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        copy[i] = arr[i];
    }
    return copy;
}

int[] array = GetArray(30, 0, 150);
int[] copy = ArrayCopy(array);
Console.WriteLine($"Массив: [{String.Join(", ", array)}]");
Console.WriteLine($"Комия массива: [{String.Join(", ", copy)}]");
