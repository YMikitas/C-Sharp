// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"


// [1;N] = 1,2,3,4,5
/// Комментарии к методу
/// start - начало, то есть, число 1 по условию
/// end - конец или число N

System.Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

if (M > N)
{
    System.Console.WriteLine("Обратный вывод не предусмотрен.");
    return;
}

string PrintNumbers(int start, int end)
{
    // Базовый случай
    if (start == end) return start.ToString(); // start - int, а метод возращает строчку
    // Рекурсивный случай
    return (start + ", " + PrintNumbers(start + 1, end));
}

Console.WriteLine(PrintNumbers(M, N));