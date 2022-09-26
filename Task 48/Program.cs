// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. 
// Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

// Заполнение массива
// [rows, columns]
// m - строчки, n - столбцы
int[,] GetMatrix(int m, int n) // Метод
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++) // строчки: matrix.GetLength(0) = m
    {
        for (int j = 0; j < n; j++) // столбцам: можно записать как matrix.GetLength(1), но лучше указывать переменную 
        {
            matrix[i,j] = i + j; // [0;10] 
        }
    }
    return matrix;
}


// Печать массива
// Входной параметр - матрица = таблица, состоящая из m строк и n столбцов
//
void PrintMatrix(int[,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++) // строки
    {
        for (int m = 0; m < inputMatrix.GetLength(1); m++) // cтолбцы
        {
            Console.Write(inputMatrix[i,m] + "\t");
        }
        Console.WriteLine();
    }
}

int[,] resultMatrix = GetMatrix(rows, columns); // Заполнение матрицы
// на rows строк и columns столбцов, элементы: [0;10]

PrintMatrix(resultMatrix);
