// Задача 39: Напишите программу, которая перевернёт 
// одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]
Console.Clear();
int[] array = GetArray(10, 0, 10);
PrintArray(array);
RevArray2(array);
Console.WriteLine();
PrintArray(array);

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

void RevArray1(int[] array)
{
    for (int i = 0; i < array.Length/2; i++)
    {
        int k = array[i];
        array[i] = array[array.Length-1-i];
        array[array.Length-1-i] = k;
    }
}

int[] RevArray2(int[] array)
{
    int[] result = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        result[i]=array[array.Length -1 -i];
    }
    return result;
}