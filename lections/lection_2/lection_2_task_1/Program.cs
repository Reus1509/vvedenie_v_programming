Console.Clear();
int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}

Console.Write("Максимальное число: ");

int a1 = 2;
int a2 = 4;
int a3 = 7;
int b1 = 45;
int b2 = 5;
int b3 = 1762;
int c1 = 1;
int c2 = 82;
int c3 = 13;

// int max1 = Max(a1,a2, a3);
// int max2 = Max(b1,b2, b3);
// int max3 = Max(c1,c2, c3);
// int max = Max(max1, max2, max3);

int max = Max(Max(a1,a2, a3), Max(b1,b2, b3), Max(c1,c2, c3));

Console.Write(max);

