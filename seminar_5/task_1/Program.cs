Console.Clear();

int[] array = GetArray(12, -9, 9);

int positiveSum = 0;
int negativeSum = 0;

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
        Console.Write($"{res[i]} ");
    }
    return res;
}

foreach (int el in array)
{
    if (el < 0)
    {
        negativeSum += el;
    }
    else
    {
        positiveSum += el;
    }
}

Console.WriteLine($"Сумма отрицательных: {negativeSum}, сумма положительных: {positiveSum}.");