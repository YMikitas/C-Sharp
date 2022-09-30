// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int rows = 9;
int columns = 3;

int[,] matrix = new int[rows, columns];
Random random = new Random();   
for (int i = 0; i < matrix.GetLength(0); i++) 
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = random.Next(0, 100);
        System.Console.Write(matrix[i, j] + "\t");
    }
    System.Console.WriteLine();
}

int index = 0;
int minsum = 0;

for (int i = 0; i < matrix.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        sum += matrix[i, j];
    }

    if (i == 0) minsum = sum;

    else if (sum < minsum)
    {
        minsum = sum;
        index = i;
    }
}

string row = string.Empty;
for (int j = 0; j < matrix.GetLength(1); j++)
{
    row += matrix[index, j] + " ";
}

System.Console.WriteLine();
Console.WriteLine($"Строка с наименьшей суммой элементов: {row}");