// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

int rows = 3;
int columns = 3;

int[,] matrix = new int[rows, columns];
Random random = new Random();

Console.WriteLine("Исходная матрица: ");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        matrix[i, j] = random.Next(0, 100);
        System.Console.Write(matrix[i, j] + "\t");
    }
    System.Console.WriteLine();
}


for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int k = 0; k < matrix.GetLength(1); k++)
        {
            if (matrix[i, j] <= matrix[i, k]) continue;
            int temp = matrix[i, j];
            matrix[i, j] = matrix[i, k];
            matrix[i, k] = temp;
        }
    }
}
 
System.Console.WriteLine();
Console.WriteLine("Отсортированная по строкам матрица: ");
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
         Console.Write(matrix[i, j] + "\t");
    }
    System.Console.WriteLine();
}