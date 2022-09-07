void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите количество строк в матрице 1: m ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов в матрице 1 и количество сток в матрице 2: n ");
int n = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов в матрице 2: s ");
int s = int.Parse(Console.ReadLine());

int[,] matrix1 = new int[m, n];
int[,] matrix2 = new int[n, s];
FillArray(matrix1);
PrintArray(matrix1);
Console.WriteLine();

FillArray(matrix2);
PrintArray(matrix2);
Console.WriteLine();
int[,] finalmatrix = new int[m, s];
int[,] CompositionMatrix (int[,] matrix1, int[,] matrix2, int[,] finalmatrix)
{
    for (int i = 0; i < finalmatrix.GetLength(0); i++)
    {
        for (int j = 0; j < finalmatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < matrix2.GetLength(0); k++)
            {
                sum += matrix1[i, k] * matrix2[k, j];
            }
            finalmatrix[i, j] = sum;
        }
    }
    return finalmatrix;
}
CompositionMatrix(matrix1, matrix2, finalmatrix);
PrintArray(finalmatrix);