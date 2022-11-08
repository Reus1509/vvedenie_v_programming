Console.Clear();
int rows = 4;
int cols = 4;
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

int[,] SwitchRows(int[,] arr)
{
    int[,] array = new int[4, 4];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            array[i, j] = arr[j, i];
        }
    }
    return array;

}

