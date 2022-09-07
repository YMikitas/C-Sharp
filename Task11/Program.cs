// Задача 11
// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа. 
// 456 -> 46 
// 782 -> 72 
// 918 -> 98

System.Console.WriteLine("Введите трёхзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 100 && num <= 999)
{
    int num1 = num / 100;
    int num2 = num % 10;
    System.Console.WriteLine($"{num1}{num2}");
}
else{
    System.Console.WriteLine("Ошибка: число не является трёхзначным.");
}