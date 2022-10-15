// Задача 35: Задайте одномерный массив из 123 случайных чисел. 
//Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

void Main(){
Console.Clear();

int[] array = NewArray(20);
WriteArray(array);
Console.WriteLine();
int count = CountNumber(array);
Console.WriteLine(count);
}

int[] NewArray(int size){
    int[] array = new int[size];
    for(int i = 0; i < size; i++){
        array[i] = new Random().Next(size * -1, size);
    }
    return array;
}

int CountNumber(int[] array)
{
    int coun = 0;
    for(int i = 0; i<array.Length;i++)
    {
        int num = array[i];
        if(num >= 10 && num <= 99){
            coun += 1;
        }
    }
    return coun;
}

void WriteArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

Main();