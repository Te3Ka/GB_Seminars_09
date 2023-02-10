/*
Напишите программу, которая на вход принимает два числа A и B,
и возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8
*/

double PowNumbers(double numA, double numB)
{
    if (numB == 1)
    {
        return numA;
    }
    else if (numB == 0)
    {
        return 1;
    }
    else if (numB < 0)
    {
        return 1 / PowNumbers(numA, Math.Abs(numB));
    }
    else
    {
        return numA * PowNumbers(numA, numB - 1);
    }
}

double GetNumber()
{
    Console.Write($"Введите значение числа: ");
    double.TryParse(Console.ReadLine(), out double result);
    return result;
}

double numberA = GetNumber();
double numberB = GetNumber();
    Console.WriteLine($"Число {numberA} в степени {numberB} = {PowNumbers(numberA, numberB)}");
