Console.Write("Введите число 1: ");
int number_1 = int.Parse(Console.ReadLine());
Console.Write("Введите число 2: ");
int number_2 = int.Parse(Console.ReadLine());
if(number_1 > number_2){
    Console.WriteLine("max = " + number_1);
}
else
{
    Console.WriteLine("max = " + number_2);
}