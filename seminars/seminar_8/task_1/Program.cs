// Задача 53: Задайте двумерный массив. Напишите программу, 
// которая поменяет местами первую и последнюю строку массива.
// Задача 55: Задайте двумерный массив. Напишите программу, 
// которая заменяет строки на столбцы. В случае, если это невозможно, 
// программа должна вывести сообщение для пользователя.

Console.Clear();
int rows = 5;
int cols = 5;
int[,] array = new int[rows, cols];
NewArray(array);
PrintArray(array);
Console.WriteLine();
int[,] secondArray = SwitchRows(array);
PrintArray(secondArray);

void NewArray(int[,] arr)
{   
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i,j]} ");
        }
        Console.WriteLine();
    }
}

int[,] SwitchRows(int[,] arr, int rows, int cols)
{

    int temp = 0;
    for (int j = 0; j < cols; j++)
    {
        temp = arr[0, j];
        arr[0, j] = arr[rows, j];
        arr[rows, j] = temp;

    }

    return arr;

}
