// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
//Парой считаем первый и последний элемент, второй и предпоследний и т.д.
//Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

void Main()
{
    Console.Clear();
    int[] array = NewArray(5);
    WriteArray(array);
    Console.WriteLine();
    int[] finish = MultNum(array);
    WriteArray(finish);
}

int[] NewArray(int size){
    int[] array = new int[size];
    for(int i = 0; i < size; i++){
        array[i] = new Random().Next(size * -1, size);
    }
    return array;
}

int[] MultNum(int[] array)
{
    int firstIndex = 0;
    int lastIndex = array.Length - 1;
    int[] newArray = new int[3];
    int result = 0;
    
    if(array.Length % 2 != 0){
        for (int i = 0; i < array.Length/2 + 1; i++)
        {   
        if(lastIndex==firstIndex){
            result = array[firstIndex];
        }
        else{
            result = array[firstIndex] * array[lastIndex];
        }
        

        firstIndex += 1;
        lastIndex -= 1;
        newArray[i] = result;
        }
    }
    else{
        for (int i = 0; i < array.Length/2; i++)
    {   
        if(lastIndex==firstIndex){
            result = array[firstIndex];
        }
        else{
            result = array[firstIndex] * array[lastIndex];
        }
        

        firstIndex += 1;
        lastIndex -= 1;
        newArray[i] = result;
    }
    return newArray;
    }
    
}

void WriteArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

Main();