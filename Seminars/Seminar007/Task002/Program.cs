// Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aij = i+j. Выведите полученный массив на экран.

int[,] NewMatrix()
{
    Console.Write("Введите количество строк числовой матрицы: ");
    int rows = int.Parse(Console.ReadLine()!);

    Console.Write("Введите количество столбцов числовой матрицы: ");
    int colums = int.Parse(Console.ReadLine()!);

    int[,] matr = new int[rows, colums];

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = i + j;
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
            Console.SetCursorPosition(k, i + 3);
            Console.Write($"{matr[i, j]} ");
        }
    }
}


Console.Clear();

int[,] matrix = NewMatrix();
PrintArray(matrix);