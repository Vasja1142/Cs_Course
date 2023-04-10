// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}

void ChangeSign(int[] inArray)
{
    for (int i = 0; i < inArray.Length; i++)
    {
       inArray[i] = -inArray[i];
    }
}

int[] array = GetArray(10, -10, 10);
Console.WriteLine($"Массив: {String.Join(", ", array)}");
ChangeSign(array);
Console.WriteLine($"Измененный массив: {String.Join(", ", array)}");