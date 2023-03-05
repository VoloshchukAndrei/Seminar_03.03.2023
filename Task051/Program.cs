// Задача 51: Задайте двумерный массив. 
// Найдите сумму элементов, находящихся
//  на главной диагонали (с индексами (0,0); (1; 1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

Console.Clear();

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());

int[,] array = GetArray(rows, columns);

PrintArray(array);

Console.WriteLine($"Сумма элементов главной диагонали: {diagonalSum(array)}");

int[,] GetArray(int M, int N)
{
    int[,] result = new int[M, N];
    for (int i = 0; i < M; i++)
    {
        for (int j = 0; j < N; j++)
        {
            result[i, j] = new Random().Next(1, 20 + 1);
        }
    }
    return result;
}

// int diagonalSum(int[,] N)
// {
//     int sum = 0;
//     for (int i = 0; i < N.GetLength(0); i++)
//     {
//         for (int j = 0; j < N.GetLength(1); j++)
//         {
//             if (i == j)
//             {
//                 sum += N[i, j];
//             }
//         }
//     }
//     return sum;
// }

int diagonalSum(int[,] N)
{
    int length = N.GetLength(0) < N.GetLength(1) ? N.GetLength(0) : N.GetLength(1);
    int sum = 0;
    for (int i = 0; i < length; i++)
    {
        sum += N[i, i];
    }
    return sum;
}

void PrintArray(int[,] N)
{
    for (int i = 0; i < N.GetLength(0); i++)
    {
        for (int j = 0; j < N.GetLength(1); j++)
        {
            Console.Write($"{N[i,j]} ");
        }
        Console.WriteLine();
    }
}