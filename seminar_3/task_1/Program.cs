﻿// Задача 18: Напишите программу, которая по заданному номеру четверти,
//  показывает диапазон возможных координат точек в этой четверти (x и y).

Console.Clear();

Console.Write("Введите номер четверти: ");
int quoter = int.Parse(Console.ReadLine());

if(quoter == 1){
    Console.WriteLine("X находится в диапазоне от 0 до + бесконечности,Y находится в интервале от 0 до + бесконечности");
}
if(quoter == 2){
    Console.WriteLine("X находится в диапазоне от 0 до - бесконечности,Y находится в интервале от 0 до + бесконечности");
}
if(quoter == 3){
    Console.WriteLine("X находится в диапазоне от 0 до - бесконечности,Y находится в интервале от 0 до - бесконечности");
}
if(quoter == 4){
    Console.WriteLine("X находится в диапазоне от 0 до + бесконечности,Y находится в интервале от 0 до - бесконечности");
}