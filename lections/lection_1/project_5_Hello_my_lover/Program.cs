Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "маша")
{
    Console.WriteLine("Привет, любимая!!");
}
else 
{
    Console.Write("Привет, ");
    Console.Write(username);
}
