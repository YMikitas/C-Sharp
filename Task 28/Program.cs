// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine()); // Глобальная переменная

System.Console.WriteLine (GetMultiply (N)); // или вызов числа с консоли
// Console.WriteLine(GetMultiply(5)); // или вызов числа из кода

int GetMultiply (int N) // Локальная переменная
{
    int result = 1;
    for (int i = 2; i <= N; i++)
    {
        result *= i; // result = resilt * i
    }
    return result;
}
