// Задача 10. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Write("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 100 && number < 1000)
{
number = number / 10;
Console.WriteLine (number % 10);
}
else
{
 Console.WriteLine ("Введено неверное значение");   
}
