// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N
// 5 -> 1, 4, 9, 16, 15


// Цикл For:
int end = Convert.ToInt32(Console.ReadLine());

for (int start = 1; start <= end; start++)
{
    System.Console.WriteLine(start * start);
}


// Цикл While:
// int start = 1;
// int end = 5;
// while (start <= end)
// {
//     System.Console.WriteLine(start * start);
//     start++;
// }
