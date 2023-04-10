// Определить последовательность Фибоначчи число операций должно быть пропорционально log(n)
// 0 1 1 2 3 5 8 13 21 34 55

double[,] MatrixCalculation(int n)
{
    n = n / 2;
    double[,] matrix = new double[2, 2];
    matrix[0, 0] = 1;
    matrix[0, 1] = 1;
    matrix[1, 0] = 1;
    matrix[1, 1] = 2;

    double[,] matrix2 = new double[2, 2];
    matrix2[0, 0] = 1;
    matrix2[1, 1] = 1;
    while (n > 1)
    {
        if (n % 2 != 0)
        {
            matrix2[0, 0] = matrix2[0, 0] * matrix[0, 0] + matrix2[1, 0] * matrix[1, 0];
            matrix2[0, 1] = matrix[0, 0] * matrix2[1, 0] + matrix[1, 0] * matrix2[1, 1];
            matrix2[1, 1] = matrix[1, 0] * matrix2[1, 0] + matrix[1, 1] * matrix2[1, 1];
            matrix2[1, 0] = matrix2[0, 1];
        }
        matrix[0, 1] = matrix[0, 0] * matrix[1, 0] + matrix[1, 0] * matrix[1, 1];
        matrix[0, 0] = matrix[0, 0] * matrix[0, 0] + matrix[1, 0] * matrix[1, 0];
        matrix[1, 1] = matrix[1, 0] * matrix[1, 0] + matrix[1, 1] * matrix[1, 1];
        matrix[1, 0] = matrix[0, 1];

        n /= 2;
    }
    
    matrix[0, 0] = matrix[0, 0] * matrix2[0, 0] + matrix[1, 0] * matrix2[1, 0];
    matrix[0, 1] = matrix2[0, 0] * matrix[1, 0] + matrix2[1, 0] * matrix[1, 1];
    matrix[1, 1] = matrix[1, 0] * matrix2[1, 0] + matrix2[1, 1] * matrix[1, 1];
    matrix[1, 0] = matrix[0, 1];
    
    return matrix;
}

Console.Clear();
Console.Write("Введите натуральное число n: ");
int n = int.Parse(Console.ReadLine()!);

Console.Clear();
double[,] matrix = MatrixCalculation(n);

double result;
if (n == 0) {result = 0;}
else if(n == 1) {result = 1;}
else if(n % 2 == 0) {result = matrix[1, 0];}
else {result = matrix[1, 1];}

Console.Write($"Ответ: {result}");

