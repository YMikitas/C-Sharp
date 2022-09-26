// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

// Заполнение массива
// [rows, columns] m - строчки, n - столбцы
double[,] GetMatrix(int m, int n) // Метод
{
    double[,] matrix = new double[m, n];
    Random random = new Random();
    for (int i = 0; i < m; i++) // строчки: matrix.GetLength(0) = m
    {
        for (int j = 0; j < n; j++) // столбцы: можно записать как matrix.GetLength(1), но лучше указывать переменную 
        {
            matrix[i, j] = random.NextDouble() * 10;
        }
    }
    return matrix;
}


// Печать массива
// Входной параметр - матрица = таблица, состоящая из m строк и n столбцов
void PrintMatrix(double[,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++) // строки
    {
        for (int j = 0; j < inputMatrix.GetLength(1); j++) // cтолбцы
        {
            Console.Write("{0,6:F2} \t", inputMatrix[i, j]);
        }
        Console.WriteLine();
    }
}

double[,] resultMatrix = GetMatrix(rows, columns); // Заполнение матрицы на rows строк и columns столбцов, элементы: [0;10]

PrintMatrix(resultMatrix);
