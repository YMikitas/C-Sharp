﻿// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int M = Convert.ToInt32(Console.ReadLine());
int N = Convert.ToInt32(Console.ReadLine());

int SumNumbers(int M, int N)
{
    if (M == N) return M;
    else return N + SumNumbers(M, N + 1);
}

Console.WriteLine(SumNumbers(M, N));
