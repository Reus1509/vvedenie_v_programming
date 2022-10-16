// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine(NumberProizved(number));

int NumberProizved(int number)
{
    int result = 1;
    for (int i = 1; i <= number; i++)
    {
        result *= i;
    }
    return result;
}