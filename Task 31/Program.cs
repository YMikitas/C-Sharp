// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

int size = 12;
int[] array = new int[size];
int resultPositive = 0;
int resultNegative = 0;

for (int i=0; i<array.Length; i++) // array.Length = size
{
    array [i] = new Random().Next(-9, 10);
    System.Console.Write(array[i] + "\t"); // "\t" Литерал табуляции
    if (array[i] > 0) resultPositive += array[i];
    else resultNegative += array[i];
}
System.Console.WriteLine("\n" + $"Positive: {resultPositive}, Negative: {resultNegative}"); // "\n" Литерал новой строки
