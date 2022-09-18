// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
//Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int size = 10;
int[] array = new int[size];
int count = 0;

for (int i = 0; i < array.Length; i++)
{
    array [i] = new Random().Next(100, 999);
    System.Console.Write(array[i] + "\t");
    if ((array[i] % 2) == 0) count++;
}

System.Console.WriteLine();
System.Console.WriteLine($"Количество чётных чисел в массиве равно " + count);
