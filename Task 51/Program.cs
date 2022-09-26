// Найти сумму элементов главной диагонали. Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

// Заполнение массива [rows, columns] m - строчки, n - столбцы
int[,] GetMatrix(int m, int n) // Метод
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < m; i++) // строчки: можно записать как matrix.GetLength(0), но лучше указывать переменную строк
    {
        for (int j = 0; j < n; j++) // столбцы: можно записать как matrix.GetLength(1), но лучше указывать переменную столбцов
        {
            matrix[i,j] = new Random().Next(11); // [0;10] 
        }
    }
    return matrix;
}

// Печать массива
// Входной параметр - матрица = таблица, состоящая из m строк и n столбцов
void PrintMatrix(int[,] inputMatrix)
{
    for (int m = 0; m < inputMatrix.GetLength(0); m++) // строки
    {
        for (int n = 0; n < inputMatrix.GetLength(1); n++) // cтолбцы
        {
            Console.Write(inputMatrix[m, n] + "\t");
        }
        Console.WriteLine();
    }
}

int[,] resultMatrix = GetMatrix(rows, columns); // Заполнение матрицы на rows строк и columns столбцов, элементы: [0;10]

PrintMatrix(resultMatrix);

int sum = 0;
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        if(i == j) sum += resultMatrix[i, j]; // (0 == 0) sum = sum + resultMatrix[i, j]
    }
}

System.Console.WriteLine($"Сумма элементов главной последовательности = {sum}");