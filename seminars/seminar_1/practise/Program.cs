Console.Write("Введите число 1: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите число 2: ");
int number2 = int.Parse(Console.ReadLine());
if(number2 == number1*number1)
{
    Console.WriteLine("Число 2 является квадратом числа 1.");
}
else
{
    Console.WriteLine("Число 2 не является квадратом числа 1.");
}
