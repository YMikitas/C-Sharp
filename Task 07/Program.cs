﻿// 7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.Write("Введите трёхзначное число: ");
int number = int.Parse(Console.ReadLine());

if (number >= 100 && number < 1000)
{
Console.WriteLine (number % 10);
}
else
{
 Console.WriteLine ("Введено неверное значение");   
}