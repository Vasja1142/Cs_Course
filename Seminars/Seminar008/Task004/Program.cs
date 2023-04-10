// Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.

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

void PrintMatrix(int[,] matr, int indent)
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
            Console.SetCursorPosition(k, i + indent);
            Console.Write($"{matr[i, j]} ");
        }
    }
}

int[,] Delete(int[,] matr)
{
    int minRow = 0;
    int minCol = 0;
    int min = matr[0, 0];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (min > matr[i, j])
            {
                min = matr[i, j];
                minRow = i;
                minCol = j;
            }
        }
    }
    int[,] newMatrix = new int[matr.GetLength(0) - 1, matr.GetLength(1) - 1];
    int row = 0;
    int col = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        if (i != minRow)
        {
            col = 0;
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                if (j != minCol)
                {
                    newMatrix[row, col] = matr[i, j];
                    col++;
                }
            }
            row++;
        }
    }
    return newMatrix;
}

Console.Clear();
int[,] matrix = NewMatrix();
Console.Clear();
PrintMatrix(matrix, 0);
int[,] newMatrix = Delete(matrix);
PrintMatrix(newMatrix, matrix.GetLength(0) + 1);