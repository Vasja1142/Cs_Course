// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.

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
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            k = j * (length + 1);
            if (matr[i, j] >= 0) k++;
            Console.SetCursorPosition(k, i + x);
            Console.Write($"{matr[i, j]} ");
        }
    }
}

int[,] Invers(int[,] matr)
{
    int temp;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = i + 1; j < matr.GetLength(1); j++)
        {
            temp = matr[i, j];
            matr[i, j] = matr[j, i];
            matr[j, i] = temp;
        }
    }
    return matr;
}


Console.Clear();
int[,] matrix = NewMatrix();
PrintMatrix(matrix, 5);
if (matrix.GetLength(0) == matrix.GetLength(1))
{
    Invers(matrix);
    PrintMatrix(matrix, matrix.GetLength(0) + 1 + 5);
}
else
{
    Console.WriteLine();
    Console.Write($"Количество строк и столбцов должно совпадать");
}