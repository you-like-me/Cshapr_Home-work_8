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

Console.Write("Введите количество строк в матрице: m ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов в матрице: n ");
int n = int.Parse(Console.ReadLine());

int[,] array = new int[m, n];
FillArray(array);
PrintArray(array);
Console.WriteLine();

int SummRow(int[,] array, int i)
{
        int sumRow = array[i, 0];
        for (int j = 1; j < array.GetLength(1); j++)
        {
            sumRow += array[i, j];
        }
        
        return sumRow;
}

int minSumRow = 0;
int SumRow = SummRow(array, 0);
for (int i = 0; i < array.GetLength(0); i++)
{
    int temp = SummRow(array, i);
    if (SumRow > temp)
    {
        SumRow = temp;
        minSumRow = i;
    }
}
Console.WriteLine($"Минимальная сумма в строке {minSumRow+1} и равна {SumRow}");
