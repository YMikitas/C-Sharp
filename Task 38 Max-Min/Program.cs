// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int size = 10;
int[] array = new int[size];

for (int i = 0; i < array.Length; i++)
{
    array [i] = new Random().Next(101);
    System.Console.Write(array[i] + "\t");
}

int min = array[0];
int max = array[0];

foreach (int i in array)
{
    if (min > i) min = i;
    if (max < i) max = i;
}

System.Console.WriteLine($"\n Max = {max}\n Min = {min}");
System.Console.WriteLine($"Разница между максимальным и минимальным элементами = {max - min}");
