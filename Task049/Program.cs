// **Задача 49:** Задайте двумерный массив.
//  Найдите элементы, у которых оба индекса чётные,
//   и замените эти элементы на их квадраты.

// Например, изначально массив выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 2 3 4

// Новый массив будет выглядеть вот так:
// 1 4 7 2
// 5 **81** 2 **9**
// 8 4 2 4
// 1 **4** 3 **16**

Console.Clear();

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());

int[,] arrayOne = GetArray(rows, columns);

PrintArray(arrayOne);

int[,] arrayFinish = SquareArray(arrayOne);

Console.WriteLine();

PrintArray(arrayFinish);

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

int[,] SquareArray(int[,] N)
{
    int[,] result = new int[N.GetLength(0), N.GetLength(1)];
    for (int i = 0; i < N.GetLength(0); i++)
    {
        for (int j = 0; j < N.GetLength(1); j++)
        {
            if (((i + 1) % 2) == 0 && ((j + 1) % 2) == 0)
            {
                result[i, j] = N[i, j] * N[i, j];
            }
            else
            {
                result[i, j] = N[i, j];
            }
        }
    }
    return result;
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