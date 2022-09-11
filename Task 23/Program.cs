// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

System.Console.WriteLine("Введите число: ");
int end = Convert.ToInt32(Console.ReadLine());

for (int start = 1; start <= end; start++)
{
    System.Console.WriteLine(start * start * start);
}





// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N
// 5 -> 1, 4, 9, 16, 15


// Цикл For:
// int end = Convert.ToInt32(Console.ReadLine());

// for (int start = 1; start <= end; start++)
// {
//     System.Console.WriteLine(start * start);
// }