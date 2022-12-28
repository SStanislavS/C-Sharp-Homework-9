// Программа заполняет спирально массив 4 на 4.
Console.Write("Введите размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] arr = new int[n, n];

int num = 1; int i = 0; int j = 1;

while (num < n * n)
{
    arr[i, j] = num;
    if (i <= j +1 && i + j < n -1)
        ++j;
    else if (i < j && i +j >= n - 1)
        ++i;
    else if (i >= j && i + j > n -1)
        --j;
    else 
        --i;
    ++num;
}

PrintArr(arr);

void PrintArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}
