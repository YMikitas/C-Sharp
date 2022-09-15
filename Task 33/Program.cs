// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

// int[] array = {6, 7, 19, 345, 4};
// bool isTrue = false;
// for (int i = 0; i < array.Length; i++)
// {
//     if(array[i] == 4)
//     {
//         isTrue = true;
//         break;
//     }
// }
// System.Console.WriteLine($"{(isTrue ? "Да" : "Нет")}"); // Тернарный оператор

int[] array = {6, 7, 19, 345, 4};
int searchNumber = 9;
bool flagResult = false;

for (int i = 0; i < array.Length; i++)
{
    if(array[i] == searchNumber)
    {
        break;
        flagResult = true; // Элемент найден
    }
}
if (flagResult) System.Console.WriteLine($"Элемент {searchNumber} присутствует");
else System.Console.WriteLine($"Элемент {searchNumber} отсутствует");