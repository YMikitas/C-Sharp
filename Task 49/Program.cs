// Задача 49. Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.


int[,] array = CreateArray(4, 5);
inr[,] IAsyncResult = UpdateArray(array);

int[,] CreateArray(int rows, int columns)
{
    int[,] array = new int [rows, columns];
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = i + j;
        }
    }
    return array;
}

int[,] UpdateArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(i % 2 == 0 && j % 2 == 0)
                array[i, j] = (int)Math.Pow(array[i, j], 2);
        }
    }
    return array;
}
