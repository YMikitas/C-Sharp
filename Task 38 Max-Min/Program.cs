// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int size = 10;
double[] array = new double[size];

for (int i = 0; i < array.Length; i++)
{
    array [i] = new Random().NextDouble() * 100;
    System.Console.Write(array[i] + "\t");
}

double min = array[0];
double max = array[0];

foreach (double i in array)
{
    if (min > i) min = i;
    if (max < i) max = i;
}

System.Console.WriteLine($"\n Max = {max}\n Min = {min}");
System.Console.WriteLine($"Разница между максимальным и минимальным элементами = {max - min}");
