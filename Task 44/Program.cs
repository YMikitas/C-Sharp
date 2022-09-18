// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

// Через массив

int n = Convert.ToInt32(Console.ReadLine());

int[] arr = new int[n];

arr[0] = 0;
arr[1] = 1;

for (int i = 2; i < n; i++)
{
    arr[i] = arr[i-1] + arr[i-2];
}

System.Console.WriteLine(string.Join(" ", arr));


// ИЛИ через числа

// int number = -10; // Кол-во чисел Фибоначчи
// if (number < 2) return;// от -бесконечности до 1 включительно
// int firstNumber = 0;  // Первое число

// int secondNumber = 1; // Второе число

// Console.WriteLine(firstNumber);
// Console.WriteLine(secondNumber);
// // i = 3
// for (int i = 3; i < number; i++)
// {
//     int nextNumber = firstNumber + secondNumber;
//     firstNumber = secondNumber;
//     secondNumber = nextNumber;
//     Console.Write(nextNumber + "\t");
// }

