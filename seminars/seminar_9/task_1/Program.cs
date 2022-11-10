
// Задача 63: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"
void Main()
{
    Console.Clear();
    int newNumber = 1;
    Console.WriteLine("Введите число: ");
    int number = int.Parse(Console.ReadLine());
    WriteNumber(number, newNumber);
}

void WriteNumber(int number, int newNumber)
{  
    Console.Write(" " + newNumber);
    if(newNumber < number)  WriteNumber(number, newNumber+1);
}

Main();