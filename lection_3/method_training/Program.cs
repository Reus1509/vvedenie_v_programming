Console.Clear();

// Первый тип методов

void Method1()
{
    Console.WriteLine("Автор ...");
}

// Второй тип методов

// void Method2(string msg, int rep)
// {
//     int i = 0;
//     while(i < rep){
//         Console.WriteLine(msg);
//         i++;
//     }
// }

// метод 2 через цикл for

void Method2(string msg, int rep)
{
    for (int i = 0; i < rep; i++)
    {
        Console.WriteLine(msg);
    }
}

// Третий тип методов

string Method3()
{
    string msg = Console.ReadLine();
    return msg;
}
int Method31()
{
    int rep = int.Parse(Console.ReadLine());
    return rep;
}

Console.Write("Введите текст: ");
string msg = Method3();
Console.Write("Сколько раз повторить?");
int rep = Method31();

Method2(msg, rep);