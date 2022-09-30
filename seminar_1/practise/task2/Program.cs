Console.Write("Введите число дня недели: ");
int day = int.Parse(Console.ReadLine());
if(day<1 || day>7){
    Console.WriteLine("Вы ввели неправильное значение!");
}
if(day == 1)Console.WriteLine("Сегодня понедельник.");
if(day == 2)Console.WriteLine("Сегодня вторник.");
if(day == 3)Console.WriteLine("Сегодня среда.");
if(day == 4)Console.WriteLine("Сегодня четверг.");
if(day == 5)Console.WriteLine("Сегодня пятница.");
if(day == 6)Console.WriteLine("Сегодня суббота.");
if(day == 7)Console.WriteLine("Сегодня воскресенье.");
day++;
