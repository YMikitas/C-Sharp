// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Write("Введите количество чисел: ");
int numbers = Convert.ToInt32(Console.ReadLine());
int[] array = new int[numbers];
for(int i = 0; i < numbers; i++)
{
    Console.WriteLine("Введите {0}-й элемент", i + 1);
    array[i] = Convert.ToInt32(Console.ReadLine());
}
int count = 0;
for (int i = 0; i < numbers; i++)
{
    if (array[i] > 0) count++;
}
Console.WriteLine($"количество введённых положительных чисел: {count}");
