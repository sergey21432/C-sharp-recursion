/* Задача 64: Задайте значения M и N. Напишите программу, которая выведет все
натуральные числа в промежутке от M до N.*/

Console.WriteLine("Task 64");

int numberNatRequery()
{
    int number = 0;
    while (number < 1)
    {
        Console.WriteLine("Please, enter a natural number:");
        number = int.Parse(Console.ReadLine());
    }
    return number;
}

void PrintIntervalNumbers(int numberMin, int numberMax)
{
    if (numberMin <= numberMax)
    {
        Console.Write(" " + numberMin);
        PrintIntervalNumbers(numberMin + 1, numberMax);
    }
    else Console.Write(".");
}

int N = numberNatRequery();
int M = numberNatRequery();

int min = M;
int max = N;
if (N < M)
{
    min = N;
    max = M;
}
Console.Write($"Natural numbers from {min} to {max}:");
PrintIntervalNumbers(min, max);
Console.WriteLine();
Console.WriteLine();

/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
натуральных элементов в промежутке от M до N.*/

Console.WriteLine("Task 66");

int SumIntervalNumbers(int numberMin, int numberMax)
{
    if (numberMin <= numberMax)
    {
        return numberMin + SumIntervalNumbers(numberMin + 1, numberMax);
    }
    else return 0;
}

N = numberNatRequery();
M = numberNatRequery();

min = M;
max = N;
if (N < M)
{
    min = N;
    max = M;
}
Console.Write($"Sum of natural numbers from {min} to {max}: {SumIntervalNumbers(min, max)}.");
Console.WriteLine();
Console.WriteLine();

/* Задача 68: Напишите программу вычисления функции Аккермана с помощью
рекурсии. Даны два неотрицательных числа m и n.*/

Console.WriteLine("Task 68");

int numberIntRequery()
{
    int number = -1;
    while (number < 0)
    {
        Console.WriteLine("Please, enter a natural number:");
        number = int.Parse(Console.ReadLine());
    }
    return number;
}

int Ackerman(int m, int n)
{
    if (m == 0) return n + 1;
    else if (m > 0 && n == 0) return Ackerman(m - 1, 1);
    else if (m > 0 && n > 0) return Ackerman(m - 1, Ackerman(m, n - 1));
    else return 0;
}

int m = numberIntRequery();
int n = numberIntRequery();
Console.WriteLine($"Ackerman function from [{m}, {n}]: {Ackerman(m, n)}.");

