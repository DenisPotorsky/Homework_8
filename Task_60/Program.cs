using static System.Console;
Clear();
// Сформируйте трёхмерный массив из 
// неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)
WriteLine("Введите строки:");
int x = int.Parse(ReadLine()!);
WriteLine("Введите столбцы:");
int y = int.Parse(ReadLine()!);
WriteLine("Введите глубину:");
int z = int.Parse(ReadLine()!);

int[] arr = GetArray(x, y, z);

int[,,] matr = FillArray(arr, x, y, z);
PrintArray(matr);

void PrintArray(int[,,] matrix3D)
{
    for (int i = 0; i < matrix3D.GetLength(0); i++)
    {
        for (int j = 0; j < matrix3D.GetLength(1); j++)
        {
            for (int k = 0; k < matrix3D.GetLength(2); k++)
            {
                Console.Write($"{matrix3D[i, j, k]}({i},{j},{k}) ");
            }
        }
        Console.WriteLine();
    }
}

int[,,] FillArray(int[] arr, int a, int b, int c)
{
    int t = 0;
    int[,,] array = new int[a, b, c];
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            for (int k = 0; k < c; k++)
            {
                array[i, j, k] = arr[t];
                t++;
            }
        }
    }
    return array;
}

int[] GetArray(int a, int b, int c)
{
    Random rnd = new Random();
    int[] array = new int[a * b * c];
    int num = 0;
    for (int i = 0; i < array.Length; i++)
    {
        num = rnd.Next(10, 100);
        if (array.Contains(num))
        {
            i--;
            continue;
        }
        array[i] = num;
    }
    return array;
}