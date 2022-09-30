// int Calculate(int a, int b);
// {
//     int result = (a + b);
//     return result;
// }
// int firstNumber = Convert.ToInt32(Console.Readline());
// int secondNumber = Convert.ToInt32(Console.Readline());

// System.Console.WriteLine($"Результат: {Calculate(firstNumber, secondNumber)}");


int Faactorial(int N)
{
    // Базовый случай, конечный: выход из рекурсии
    if (N == 1) return 1; // Факториал от 1 это 1

    // Рекурсивный случай, вызов функции через саму себя
    return (N * Faactorial(N-1));
}

System.Console.WriteLine(Faactorial(5));


