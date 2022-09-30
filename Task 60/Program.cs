// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int rows = 5;
int columns = 5;
int deep = 5;

int[, ,] GetMatrix(int m, int n, int o)
{
    int[, ,] matrix = new int[m, n, o];
    int num = 10;
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int k = 0; k < o; k++)
            {
                if (num < 100) matrix[i,j, k] = num++;
                else matrix[i,j, k] = -1;
            }
        }
    }
    return matrix;
}

void PrintMatrix(int[, ,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inputMatrix.GetLength(1); j++)
        {
            for (int k = 0; k < inputMatrix.GetLength(2); k++)
            {
                Console.Write(inputMatrix[i, j, k] + $" ({i}, {j}, {k}) \t");
            }
            Console.WriteLine();
        }
    }
}

int[, ,] resultMatrix = GetMatrix(rows, columns, deep);

PrintMatrix(resultMatrix);
