Console.Clear();
void AddElements(int[] array)
{
    int length = array.Length;
    int count = 0;
    while(count < length){
        array[count] = new Random().Next(1,10);
        count++;
    }
}
void PrintMassive(int [] array){
    int length = array.Length;
    int count = 0;
    while(count < length){
        Console.Write(array[count] + " ");
        count++;
    }
}

int[] array = new int[10];

AddElements(array);
PrintMassive(array);