// Задайте значение N. Программа выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
Console.WriteLine("Введите натуральное число от 1:");
int number = int.Parse(Console.ReadLine());

void PrintNumberRevers (int number)
{
    if (number < 0)
    Console.Write($" {number} не натуральное число ");
    if ( number == 0)
    {
        return;
    }
    Console.Write(" " + number);
    PrintNumberRevers (number - 1);
}
PrintNumberRevers(number);
