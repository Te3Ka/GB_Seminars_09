/*
Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 6, 7, 8"
*/

void PrintNumber(int M, int N)
{
    if (M > N)
    {
        PrintNumber(M - 1, N);
        Console.Write($", {M}");
    }
    else if (M < N)
    {
        PrintNumber(M, N - 1);
        Console.Write($", {N}");
    }
    else if (M == N)
    {
        Console.Write($"{M}");
    }
}

int GetNumber()
{
    Console.Write($"Введите значение числа: ");
    int.TryParse(Console.ReadLine(), out int result);
    return result;
}

int M = GetNumber();
int N = GetNumber();
PrintNumber(M, N);