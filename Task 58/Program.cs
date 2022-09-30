// Задача 58: Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.

int rows = 2;
int columns = 2;

System.Console.WriteLine("Матрица A: ");
int[,] matrix1 = new int[rows, columns];
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        matrix1[i,j] = new Random().Next(10);
        Console.Write("{0}\t", matrix1[i, j]);
    }
    Console.WriteLine();
}

System.Console.WriteLine();
System.Console.WriteLine("Матрица B: ");
int[,] matrix2 = new int[rows, columns];
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        matrix2[i,j] = new Random().Next(10);
        Console.Write("{0}\t", matrix1[i, j]);
    }
    Console.WriteLine();
}

System.Console.WriteLine();

System.Console.WriteLine("Результат перемножения матриц A и B: ");
int[,] Multiplication(int[,] m, int[,] n)
{
    int[,] res = new int[m.GetLength(0), n.GetLength(1)];
    for (int i = 0; i < m.GetLength(0); i++)
    {
        for (int j = 0; j < n.GetLength(1); j++)
        {
            for (int k = 0; k < n.GetLength(0); k++)
            {
                res[i,j] += m[i,k] * n[k,j];
            }
        }
    }
    return res;
}
void Print(int[,] o)
{
    for (int i = 0; i < o.GetLength(0); i++)
    {
        for (int j = 0; j < o.GetLength(1); j++)
        {
            Console.Write("{0} ", o[i, j]);
        }
        Console.WriteLine();
    }
}

int[,] resultMatrix = Multiplication(matrix1, matrix2);
Print(resultMatrix);