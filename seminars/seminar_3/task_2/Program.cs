// Задача 21: Напишите программу, которая принимает на вход координаты двух
//  точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

Console.Write("Координату x точки А: ");
double ax = int.Parse(Console.ReadLine());

Console.Write("Координату y точки А: ");
double ay = int.Parse(Console.ReadLine());

Console.Write("Координату x точки B: ");
double bx = int.Parse(Console.ReadLine());

Console.Write("Координату y точки B: ");
double by = int.Parse(Console.ReadLine());

double result = Math.Sqrt(Math.Pow(bx - ax, 2) + Math.Pow(by - ay, 2));

Console.WriteLine($"Расстояние между двумя точками равно: {Math.Round(result, 2)}");