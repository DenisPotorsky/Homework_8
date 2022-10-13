using static System.Console;
Clear();
// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить 
// строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке 
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка
WriteLine("Задайте прямоугольный массив");
WriteLine("Строки: ");
int a = int.Parse(ReadLine()!);
WriteLine("Столбцы: ");
int b = int.Parse(ReadLine()!);
int[,] arr = CreateArray(a, b);
WriteLine();
PrintArray(arr);
WriteLine();
RowSmallSum(arr);

int[,] CreateArray(int rows, int col)
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

void RowSmallSum(int[,] array)
{
    int index = 1;
    int min = 0;
    
    for (int i = 0; i < array.GetLength(1); i++)
    {
        min += array[0, i];
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        } 
        if(sum < min)
        {
        min = sum;
        index = i + 1;
        }
    }
    Write($"Номер строки с наименьшей суммой элементов: {index}");
}