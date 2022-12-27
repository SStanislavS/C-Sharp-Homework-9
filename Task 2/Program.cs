// Задайте значения M и N. Программа находит сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
Console.Write("Введите натуральное число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число N: ");
int N = Convert.ToInt32(Console.ReadLine());

void PrintSumNumbers (int M, int N, int sum)
{
    if (M > N)
    {
        Console.WriteLine("Сумма натуральных элементов: " + sum);
        return;
    }
    sum = sum + (M++);
    PrintSumNumbers (M, N, sum);
}
PrintSumNumbers (M, N, 0);