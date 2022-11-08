int[] array = new int[] {4, 5, 1, 14, 147, 122, 314, 123, 151, 531, 213, 412, 11, 32};
PrintArray(array);
Console.WriteLine();
BubbleSort(array);
PrintArray(array);
int result = Binary_Search(array, 151);
Console.WriteLine($"число находится на {result} месте в массиве.");

static void BubbleSort(int[] inArray)
{
    for (int i = 0; i < inArray.Length; i++)
        for (int j = 0; j < inArray.Length - i - 1; j++)
        {
            if (inArray[j] > inArray[j + 1])
            {
                int temp = inArray[j];
                inArray[j] = inArray[j + 1];
                inArray[j + 1] = temp;
            }
        }
}

int Binary_Search(int[] arr, int item)
{
    
    // while(low <= high)
    // {
    //     middle = ((low + high) / 2);
    //     int guess = arr[middle];
    //     if (guess == item) return middle;
    //     if (guess > item) high = middle -1;
    //     else
    //     {
    //         low = middle + 1; 
    //     }
    // }
    int high = arr.Length -1;
    int middle = 0;
    for (int i = 0; i < high; i++)
    {
        middle = ((i + high) / 2);
        int guess = arr[middle];
        if (guess == item) return middle;
        if (guess > item) high = middle -1;
        else
        {
            i = middle + 1; 
        }
    }
    return middle;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}