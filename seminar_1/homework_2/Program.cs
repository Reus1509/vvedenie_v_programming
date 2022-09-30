Console.Write("Введите число 1: ");
int number_1 = int.Parse(Console.ReadLine());
Console.Write("Введите число 2: ");
int number_2 = int.Parse(Console.ReadLine());
Console.Write("Введите число 3: ");
int number_3 = int.Parse(Console.ReadLine());
int[] arr = new int[3]{number_1,number_2,number_3};
int max = arr[0];
int count = 0;
while(count < 3)
{
    if(arr[count] > max)
    {
        max = arr[count];
    }
    count++;
}
Console.WriteLine(max);