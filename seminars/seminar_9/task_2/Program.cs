// Задача 65: Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"
void Main()
{
    Console.Clear();
    Console.WriteLine("Введите число 1: ");
    int number1 = UserInput();
    Console.WriteLine("Введите число 2: ");
    int number2 = UserInput();
    WriteNumber(number1, number2);
}

int UserInput()
{
    int number = int.Parse(Console.ReadLine());
    return number;
}

void WriteNumber(int number1, int number2)
{  
    Console.Write(" " + number1);
    if(number1 < number2)  WriteNumber(number1+1, number2);
}

Main();