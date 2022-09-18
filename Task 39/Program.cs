// Задача 39: Напишите программу, которая перевернёт
// одномерный массив (последний элемент будет 
// на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

// int size = Convert.ToInt32(Console.ReadLine()); // Размер массива

// int[] array = new int[size]; // size = 3, array = [0,0,0]

// for (int i = 0; i < size; i++) // array.Length = size
// {
//     array[i] = new Random().Next(11); // [0;10]
//     Console.Write(array[i] + "\t"); // "\t" - Tab между элементами
// }

// 1. "Перевернутая" копия массива
// System.Console.WriteLine();
// Console.WriteLine("Перевернутый массив: ");
// int[] reverseArray = new int[size]; // Размер копии совпадает с размером оригинала
// int lastIndex = size - 1; // Размер с 1, индексы с 0 
// for (int i = 0; i < size; i++)
// {
//     reverseArray[i] = array[lastIndex - i];
//     Console.Write(reverseArray[i] + "\t");
// }

// 2. Замена пузырьком
int[] array = GetArray(10, 0, 10); // size = 10, диапазон элементов: [0;10]
Console.WriteLine(String.Join(" ", array));

int[] reversArray = CopyArray(array);
Console.WriteLine(String.Join(" ", reversArray)); // С копией массива, оригинал не изменяется

ReverseArray(array);
Console.WriteLine(String.Join(" ", array));
// Меняете исходный массив, но дополнительный массив не создается

int[] GetArray(int size, int minValue, int maxValue)
{
int[] res = new int[size];

for (int i = 0; i < size; i++)
{
    res[i] = new Random().Next(minValue, maxValue + 1);
}
return res;
}

void ReverseArray(int[] inArray)
{
for (int i = 0; i < inArray.Length / 2; i++)
{
int temp = inArray[i];
inArray[i] = inArray[inArray.Length - i - 1];
inArray[inArray.Length - i - 1] = temp;
}
}

int[] CopyArray(int[] inArray)
{
int[] result = new int[inArray.Length];
for (int i = 0; i < inArray.Length; i++) // inArray.Length = size
{
result[i] = inArray[inArray.Length - 1 - i]; // size - 1
}
return result;
}
