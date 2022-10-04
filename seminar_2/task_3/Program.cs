// 14. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет 
// 46 -> нет 
// 161 -> да
Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
// if (number % 7 == 0){
//     if (number % 23 == 0){
//         Console.WriteLine($"Число {number} кратно и 7 и 23.");
//         return;
//     }
//     Console.WriteLine($"Число {number} кратно 7 но не кратно 23.");
// }
// else{
//     Console.WriteLine($"Число {number} не кратно ни 7 ни 23.");
// }

if(number % 7 == 0 && number % 23 == 0){
    Console.WriteLine($"Число {number} кратно и 7 и 23.");
}
else{
    Console.WriteLine($"Число {number} не кратно  7 или 23.");
}