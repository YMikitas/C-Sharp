// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в двумерном пространстве

// System.Console.WriteLine("Input X1: ");
// int X1 = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine("Input Y1: ");
// int Y1 = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine("Input X2: ");
// int X2 = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine("Input Y2: ");
// int Y2 = Convert.ToInt32(Console.ReadLine());

// double d = Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2));

// System.Console.WriteLine($"Расстояние межжду точками: {Math.Round(d, 3)}");


// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

System.Console.WriteLine("Input X1: ");
int X1 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Input Y1: ");
int Y1 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Input Z1: ");
int Z1 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Input X2: ");
int X2 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Input Y2: ");
int Y2 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Input Z2: ");
int Z2 = Convert.ToInt32(Console.ReadLine());

double d = Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2) + Math.Pow(Z2 - Z1, 2));

System.Console.WriteLine($"Расстояние межжду точками: {Math.Round(d, 2)}");