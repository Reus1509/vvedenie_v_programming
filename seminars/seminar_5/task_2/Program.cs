// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 
// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

Console.Clear();

int[] array = NewArray(4);
WriteArray(array);
Console.WriteLine();
int[] newArray = ReverseEl(array);
WriteArray(newArray);

int[] NewArray(int size){
    int[] array = new int[size];
    for(int i = 0; i < size; i++){
        array[i] = new Random().Next(size * -1, size);
    }
    return array;
}

int[] ReverseEl(int[] arr){
    for(int i = 0; i<arr.Length;i++){
         arr[i] *= -1;
    }
    return arr;
}

void WriteArray(int[] arr){
    for(int i=0; i<arr.Length;i++){
        Console.Write($"{arr[i]} ");
    }
}