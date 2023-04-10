Console.Clear();
// string[,] table = new string[2, 5];
// //String.Empty
// table[1, 2] = "слово";

// for (int rows = 0; rows < 2; rows++)
// {
//     for (int colums = 0; colums < 5; colums++)
//     {
//         Console.WriteLine($"-{table[rows, colums]}-");
//     }
// }

int[, ] matrix = new int[3, 4];


void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
     Console.WriteLine();
}


void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(1,10);
        }
    }
}

PrintArray(matrix);
FillArray(matrix);
PrintArray(matrix);

// int Factorial(int n)
// {
//     if (n == 1) return 1;
//     else return n * Factorial(n - 1);
// }

// Console.WriteLine(Factorial(3));

// double Fibonacci(int n)
// {
//     if (n == 0) return 1;
//     else 
//         if (n == 1) return 1;
//         else return Fibonacci(n - 1) + Fibonacci(n - 2);
// }

// for (int i = 0; i < 40; i++)
// {
//     Console.WriteLine($"f({i}) = {Fibonacci(i)}");
// }
