// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

void Main()
{
    Console.Clear();
    Console.Write("Введите число: ");
    int number = int.Parse(Console.ReadLine());
    int result = SumElements(number);
    Console.Write(result);
}

int SumElements(int number)
{
    if(number == 0) return 0;
    return number % 10 + SumElements(number / 10);
}

Main();