// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine(NumberLenght(number));

// double NumberLenght(int number){
//     double len = Math.Floor(Math.Log10(number) + 1);
//     return len;
// }

int NumberLenght(int number){
    int result = 0;
    for(int num = 0; number > 0; num++){
        number /= 10;
        result++;
    }
    return result;
}