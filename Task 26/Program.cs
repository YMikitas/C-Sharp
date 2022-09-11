// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

// string number = Console.ReadLine();
// Console.WriteLine(number.Length);

System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(GetCountNumbers(number));

int GetCountNumbers (int num)
{
    int count = 0; // изначально нет числа и 0 цифр
    while (num > 0)
    {
        count ++;
        num /= 10;
    }
    return count; // количество цифр в числе
}
