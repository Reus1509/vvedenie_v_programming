Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int a = number * -1;
if(number < 0){
    while(number <= a){
        Console.Write(number);
        number++;
    }
}
else{
    while(a <= number)
    {
        Console.Write(a);
        a++;
    }
}

