// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int oldValue = number;
int newValue = 0;
while (number > 0)
{
    int dig = number % 10;
    newValue = newValue * 10 + dig;
    number = number / 10;
}
if (newValue == oldValue)
{
    System.Console.WriteLine("Введённое число является палиндромом");
}
else
{
    System.Console.WriteLine("Введённое число не является палиндромом");
}
