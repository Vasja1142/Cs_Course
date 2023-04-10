
string[] FillArray()
{
    Console.Write("Введите длинну массива: ");
    int size = int.Parse(Console.ReadLine()!);

    string[] result = new string[size];
    string value = string.Empty;
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите {i + 1}-е значение массива: ");
        value = Console.ReadLine()!;
        result[i] = value;
    }
    return result;

}

string[] ArrayFilter(string[] array)
{
    
    int length = 0;
    string text = string.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) 
        {
            length++;
        }
    }

    int value = 0;
    string[] result = new string[length];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            result[value++] = array[i];
        }
    }
    return result;

}


Console.Clear();
string[] array = FillArray();
string[] result = ArrayFilter(array);
Console.WriteLine($"Заданный массив: [{String.Join(", ", array)}]");
Console.WriteLine($"Итоговый массив: [{String.Join(", ", result)}]");
