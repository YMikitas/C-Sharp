// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int rows = 3;
int columns = 3;

int[,] matrix = new int[rows, columns];
Random random = new Random();

int[] arithMean = new int[columns];

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        matrix[i, j] = random.Next(0, 10);
    }
}

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        System.Console.Write(matrix[i, j] + "\t");
        arithMean[i] += matrix[j, i];
    } 
    System.Console.WriteLine();
}

System.Console.WriteLine();
System.Console.WriteLine("Среднее арифметическое элементов в каждом столбце: ");
foreach (double item in arithMean)
{
    Console.WriteLine(item/columns);
}
 