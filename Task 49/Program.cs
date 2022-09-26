// Задача 49. Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

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
    for (int i = 0; i < inputMatrix.GetLength(0); i++) // строки
    {
        for (int m = 0; m < inputMatrix.GetLength(1); m++) // cтолбцы
        {
            Console.Write(inputMatrix[i,m] + "\t");
        }
        Console.WriteLine();
    }
}

int [,] ChangeArray(int[,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0) // индексы i и j должны быть чётными, т.е. при делении на 2 остаток должен быть 0
            {
                inputArray[i, j] *= inputArray[i, j];
            }
        }
    }
    return inputArray;
}

int[,] resultMatrix = GetMatrix(rows, columns); // Заполнение матрицы на rows строк и columns столбцов, элементы: [0;10]

PrintMatrix(resultMatrix);
System.Console.WriteLine();
PrintMatrix(ChangeArray(resultMatrix));