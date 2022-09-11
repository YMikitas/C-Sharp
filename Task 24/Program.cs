// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

int A = Convert.ToInt32(Console.ReadLine()); // правая граница
int sum = 0; // Изначально переменная для суммы пустая
for (int i = 1; i <= A; i++)
{
    sum += i; // sum = sum + i
}
Console.WriteLine($"Сумма чисел от 1 до {A} = {sum}");


System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(SumNumbers(number));

int SumNumbers (int end) // end = A. локальная переменная (внутри метода)
{
    int sum = 0;
    for (int i = 1; i <= end; i++)
    {
        sum += i;
    }
    return sum;
}
