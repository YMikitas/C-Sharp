// Напишите программу, которая принимает на вход координаты точки (X и Y), причём они != 0, и выдаёт номер четверти плоскости, в которой находится эта точка

Console.Write("Input X: ");
int X = Convert.ToInt32(Console.ReadLine());

Console.Write("Input Y: ");
int Y = Convert.ToInt32(Console.ReadLine());

if (X > 0 && Y > 0) Console.WriteLine("I четверть");
else if (X < 0 && Y > 0) Console.WriteLine("II четверть");
else if (X < 0 && Y < 0) Console.WriteLine("III четверть");
else Console.WriteLine("IV четверть");
