// Задайте двумерный массив.
// Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д

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

void PrintArray(int[,] matr)
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
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            k = j * (length + 1);
            if (matr[i, j] >= 0) k++;
            Console.SetCursorPosition(k, i + 5);
            Console.Write($"{matr[i, j]} ");
        }
    }
}

int Calc(int[,] matr)
{
    int result = 0;
    for (int i = 0; i < matr.GetLength(0) & i < matr.GetLength(1); i ++)
    {
        result += matr[i, i];
    }
    return result;
}
Console.Clear();

int[,] matrix = NewMatrix();

PrintArray(matrix);
Console.WriteLine();
Console.Write($"Ответ: {Calc(matrix)}");