// 16. Напишите программу, которая принимает на вход два числа и проверяет,
// является ли одно число квадратом другого.
// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет
Console.Clear();
Console.Write("Введите число 1: ");
int first_number = int.Parse(Console.ReadLine());
Console.Write("Введите число 2: ");
int second_number = int.Parse(Console.ReadLine());
if(first_number*first_number == second_number){
    Console.WriteLine($"Число {second_number} является квадратом числа {first_number}.");
    return;
}
if(second_number*second_number == first_number){
    Console.WriteLine($"Число {first_number} является квадратом числа {second_number}.");
    return;
}
Console.WriteLine("Числа не являются квадратами друг друга.");