//код именен с констант

Console.Clear();
int[] array = {13, 21, 33, 24, 25, 33, 17, 68};

int n = array.Length;
int find = 33;

int index = 0;

while(index < n){
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}