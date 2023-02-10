/*
Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6"
*/

void PrintNumber(int N)
{
    if (N <= 0)
    {
        return;
    }
    else if (N == 1)
    {
        Console.Write($"{N}");
    }
    else
    {
        PrintNumber(N - 1);
        Console.Write($", {N}");
    }
}

int GetNumber()
{
    Console.Write($"Введите значение числа: ");
    int.TryParse(Console.ReadLine(), out int result);
    return result;
}

int num = GetNumber();
PrintNumber(num);