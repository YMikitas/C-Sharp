// Задача 67: Напишите программу, которая будет принимать 
// на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

int number = Convert.ToInt32(Console.ReadLine());

int SumNumber(int num)
{
    // Базовый случай
    if (num == 0) return 0; // 45 -> 4+5+0 = 9; sum + 0 = sum
    // Рекурсивный случай
    return (num % 10 + SumNumber(num / 10)); // num%10 => ПОСЛЕДНЯЯ цифра числа
}

Console.WriteLine(SumNumber(number));
