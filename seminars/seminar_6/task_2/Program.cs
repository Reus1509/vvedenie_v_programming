// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

void Main(){
    Console.Clear();
    int number1 = GetNumber();
    int number2 = GetNumber();
    int number3 = GetNumber();
    CheckingTri(number1, number2, number3);
}


int GetNumber()
{
    Console.Write("Введите число: ");
    int number = int.Parse(Console.ReadLine());
    return number;
}

void CheckingTri(int num1, int num2, int num3)
{
    if(num1 > 0 && num2 > 0 && num3 > 0)
    {
        if((num1+num2)>num3 && (num1+num3)>num2 && (num2+num3)>num1)
        {
            Console.WriteLine($"Треугольник со сторонами {num1}, {num2}, {num3} существует.");
        }
        else Console.WriteLine($"Треугольник со сторонами {num1}, {num2}, {num3} не существует.");
    }
    else Console.WriteLine("Одно из чисел меньше 0.");
}
Main();