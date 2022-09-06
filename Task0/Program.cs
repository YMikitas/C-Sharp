// Напишите программу, которая на вход принимает число и выдаёт его квадрат.

System.Console.Write("Введите число: ");
int number = Convert.ToInt16(Console.ReadLine());
// int sqr = number * number;
// System.Console.WriteLine($"Квадрат числа {number} равен {sqr}");
int sqr = Convert.ToInt32(Math.Pow(number, 2)); // Втроенный метод
System.Console.WriteLine($"Квадрат числа {number} равен {sqr}");
