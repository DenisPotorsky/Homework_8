using static System.Console;
Clear();
// Задайте две матрицы. 
// Напишите программу, которая будет 
// находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
WriteLine("Задайте размер матриц");
WriteLine();
WriteLine("Строки первой матрицы: ");
int a = int.Parse(ReadLine()!);
WriteLine("Столбцы первой матрицы: ");
int b = int.Parse(ReadLine()!);
WriteLine();

WriteLine("Строки второй матрицы: ");
int c = int.Parse(ReadLine()!);
WriteLine("Столбцы второй матрицы: ");
int d = int.Parse(ReadLine()!);
WriteLine();

if (b != c)
{
    WriteLine("Умножение невозможно.\nУкажите количество столбцов первой матрицы равное количеству строк второй матрицы.");
    return;
}

int[,] matrix1 = FillArray(a, b);
int[,] matrix2 = FillArray(c, d);
int[,] resultMatrix = FillArray(a, d);

FillArray(a, b);
PrintArray(matrix1);
WriteLine();
FillArray(c, d);
PrintArray(matrix2);
WriteLine();
MatrixProduct(matrix1, matrix2, resultMatrix);
PrintArray(resultMatrix);

int[,] FillArray(int rows, int col)
{
    Random rnd = new Random();
    int[,] array = new int[rows, col];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array[i, j] = rnd.Next(1, 10);
        }
    }
    return array;
}

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
}

void MatrixProduct(int[,] matr1, int[,] matr2, int[,] resultMatr)
{
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < matr1.GetLength(1); k++)
            {
                sum += matr1[i, k] * matr2[k, j];
            }
            resultMatrix[i, j] = sum;
        }
    }
}
