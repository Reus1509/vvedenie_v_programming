//Та же задача, но с использованием массивов

Console.Clear();
int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}

Console.Write("Максимальное число: ");

int[] array = {41, 22, 39, 64, 51, 76, 17, 48, 49};

// int max1 = Max(a1,a2, a3);
// int max2 = Max(b1,b2, b3);
// int max3 = Max(c1,c2, c3);
// int max = Max(max1, max2, max3);

int max = Max(Max(array[0],array[1], array[2]), Max(array[3],array[4], array[5]), Max(array[6],array[7], array[8]));

Console.Write(max);


