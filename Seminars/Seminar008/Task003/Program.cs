// Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

int[,] NewMatrix()
{
    Console.Write("Введите количество строк числовой матрицы: ");
    int rows = int.Parse(Console.ReadLine()!);

    Console.Write("Введите количество столбцов числовой матрицы: ");
    int colums = int.Parse(Console.ReadLine()!);

    Console.Write("Введите минимальное значение элемента матрицы: ");
    int minValue = int.Parse(Console.ReadLine()!);

    Console.Write("Введите максимальное значение элемента матрицы: ");
    int maxValue = int.Parse(Console.ReadLine()!);

    int[,] matr = new int[rows, colums];

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return matr;
}

void PrintMatrix(int[,] matr, int x)
{
    int max = 1;
    int l = 1;
    int k = 1;
    int length = 1;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (max < Math.Abs(matr[i, j])) max = Math.Abs(matr[i, j]);
        }
    }

    while (l <= max)
    {
        l *= 10;
        length++;
    }

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(0); j++)
        {
            k = j * (length + 1);
            if (matr[i, j] >= 0) k++;
            Console.SetCursorPosition(k, i + x);
            Console.Write($"{matr[i, j]} ");
        }
    }
}

int[] Convers(int[,] matr)
{
    int[] array = new int[matr.GetLength(0) * matr.GetLength(1)];
    int k = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            array[k++] = matr[i, j];
        }
    }
    return array;
}

int[] SortingElements(int[] array)
{
    int min;
    int indexMin;
    for (int i = 0; i < array.Length; i++)
    {
        min = array[i];
        indexMin = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (min > array[j])
            {
                min = array[j];
                indexMin = j;
            }
        }
        if (i != indexMin)
        {
            array[i] += min;
            array[indexMin] = array[i] - array[indexMin];
            array[i] -= array[indexMin];
        }
    }
    return array;
}

void Calc(int[] array)
{
    int count = 1;
    for (int i = 0; i < array.Length - 1; i++)
    {
        if (array[i] == array[i + 1]) count++;
        else
        {
            Console.WriteLine($"Переменных [{array[i]}] = {count}");
            count = 1;
        }
    }
    Console.WriteLine($"Переменных [{array[array.Length - 1]}] = {count}");
}

Console.Clear();
int[,] matrix = NewMatrix();
PrintMatrix(matrix, 5);
int [] array = Convers(matrix);
Console.WriteLine();
Console.WriteLine($"Массив: [{String.Join(", ", array)}]");
SortingElements(array);
Console.WriteLine($"Сортированный массив: [{String.Join(", ", array)}]");
Console.WriteLine();
Calc(array);