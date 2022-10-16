// 12. Напишите программу, которая будет принимать на вход два числа и выводить, 
//является ли второе число кратным первому. Если число 2 не кратно числу 1, 
//то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно
Console.Clear();
Console.Write("Введите число 1: ");
int first_number = int.Parse(Console.ReadLine());
Console.Write("Введите число 2: ");
int second_number = int.Parse(Console.ReadLine());
if (first_number == 0){
    Console.WriteLine("Error, 0!!!");
    return;
}

int result = second_number % first_number;

if(result == 0){
    Console.WriteLine($"Число {second_number} кратно {first_number}.");
}
else{
    Console.WriteLine($"Число {second_number} не кратно {first_number}, остаток от деления равен {result}.");
}