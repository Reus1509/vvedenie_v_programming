Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
if(number > 1000 || number < 100)Console.Write("Вы ввели неправильное число!!!");
else{
    number = number % 10;
    Console.WriteLine(number);}