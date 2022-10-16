// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

Console.Clear();
int isOrNot = 0;
int number = UserInput();
int[] array = NewArray(10);
int value = FindInArray(array);
WriteArray(array);

Console.WriteLine();

if (value > 0){
    Console.WriteLine($"Число {number} есть!");
}
else{
    Console.WriteLine($"Числа {number} нет!");
}

int UserInput(){
    Console.Write("Введите число: ");
    int number = int.Parse(Console.ReadLine());
    return number;
}

int[] NewArray(int size){
    int[] array = new int[size];
    for(int i = 0; i < size; i++){
        array[i] = new Random().Next(size * -1, size);
    }
    return array;
}

int FindInArray(int[] array){
    foreach(int el in array){
        if(el == number){
            isOrNot += 1;
        }
    }
    return isOrNot;
}

void WriteArray(int[] arr){
    for(int i=0; i<arr.Length;i++){
        Console.Write($"{arr[i]} ");
    }
}