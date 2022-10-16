int count = 0,  firstFriendSpeed = 2, secondFriendSpeed = 4, dogSpeed = 6, friend = 2;
double distance = 100000, time = 0;

while(distance > 10)
{
    if(friend == 1)
    {
        time = distance/(firstFriendSpeed + dogSpeed);
        friend = 2;
    }
    else
    {
        time = distance/(secondFriendSpeed + dogSpeed);
        friend = 1;
    }

    distance = distance - (firstFriendSpeed + secondFriendSpeed) * time;
    count++;
}

Console.Write("Собака пробежит: ");
Console.Write(count );
Console.WriteLine("раз.");

