/*
Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
453 -> 12
45 -> 9
*/

int SumDigits(int num)
{
    if (num < 10)
    {
        return num;
    }
    else
    {
        return num % 10 + SumDigits(num / 10);
    }
}

int GetNumber()
{
    Console.Write($"Введите значение числа: ");
    int.TryParse(Console.ReadLine(), out int result);
    return result;
}

int number = Math.Abs(GetNumber());
Console.WriteLine($"Сумма цифр числа {number} = {SumDigits(number)}");