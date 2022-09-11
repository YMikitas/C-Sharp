// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int[] GetBinaryArray (int size)
{
    int[] array = new int[size]; // size = 5 -> array = [0, 0, 0, 0, 0]
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(2);
    }
    return array;
}

int[] resultArray = GetBinaryArray(8);

System.Console.WriteLine($"ResultArray: [ {String.Join("; ", resultArray)} ]"); // конвертация массива в строку
