void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] < 10)
            {
                Console.Write("0" + arr[i, j] + " ");
            }
            else Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}
Console.Write("Введите количество строк и столбцов в матрице: n ");
int n = int.Parse(Console.ReadLine());

int[,] array = new int[n, n];
int temp = 1;
int i = 0;
int j = 0;

while (temp <= array.GetLength(0) * array.GetLength(1))
{
    array[i, j] = temp;
    temp++;
    if (i <= j + 1 && i + j < array.GetLength(1) - 1)
        j++;
    else
    {
        if (i < j && i + j >= array.GetLength(0) - 1)
            i++;
        else
        {
            if (i >= j && i + j > array.GetLength(1) - 1)
                j--;
        
            else i--;
        }

    }

}


PrintArray(array);