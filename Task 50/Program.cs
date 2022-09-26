// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int rows = 5;
int columns = 5;

System.Console.Write("Введите индекс строки: ");
int indexOfRow = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите индекс колонки: ");
int indexOfColumn = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[rows, columns];
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        matrix[i,j] = new Random().Next(101);
        Console.Write("{0}\t", matrix[i, j]);
    }
    Console.WriteLine();
}

if (indexOfRow < 0 | indexOfRow > matrix.GetLength(0) - 1 | indexOfColumn < 0 | indexOfColumn > matrix.GetLength(1) - 1)
{
    Console.WriteLine("Такого числа в массиве нет");
}
else
{
    Console.WriteLine("Значение элемента массива = {0}", matrix[indexOfRow, indexOfColumn]);
}
