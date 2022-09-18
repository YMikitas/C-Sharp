﻿// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int size = 10;
int[] array = new int[size];
int sum = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(101);
    Console.Write(array[i] + "\t");
    if(i % 2 == 1)
    sum += array[i];
}

System.Console.Write($"\nСумма элементов, стоящих на нечётных позициях = {sum}");
