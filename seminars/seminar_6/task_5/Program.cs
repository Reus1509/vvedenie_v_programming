//  Задача 45: Напишите программу, которая будет создавать
//   копию заданного массива с помощью поэлементного копирования.
void Main()
{
    Console.Clear();

    int[] array =new int[5];
    CreateArray(array);
    WriteArray(array);
    Console.WriteLine();
    int[] newArray = NewArray(array);
    array[0] = 2;
    WriteArray(array);
    Console.WriteLine();
    WriteArray(newArray);
}


int[] CreateArray(int[] array){
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1,25);
    }
    return array;
}

int[] NewArray(int[] array)
{   
    int[] newArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        newArray[i] = array[i];
    }
    return newArray;
}
void WriteArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

Main();