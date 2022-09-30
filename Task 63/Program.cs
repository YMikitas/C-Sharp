// Задача 63: Задайте значение N. Напишите программу,
// которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

// [1;N] = 1,2,3,4,5
/// Комментарии к методу
/// start - начало, то есть, число 1 по условию
/// end - конец или число N
int N = Convert.ToInt32(Console.ReadLine());
string PrintNumbers(int start, int end)
{
    // Базовый случай
    if (start == end) return start.ToString(); // start - int, а метод возращает строчку
    // Рекурсивный случай
    return (start + ", " + PrintNumbers(start + 1, end));
}

Console.WriteLine(PrintNumbers(1, N));
