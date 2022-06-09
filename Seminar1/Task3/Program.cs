/* Напишите программу, которая будет выдавать название дня недели по заданному номеру.
3 -> Среда
5 -> Пятница */

Console.Write("Введите цифру от 1 до 7 ");
int day = int.Parse(Console.ReadLine());

if(day == 1)
{
    Console.WriteLine("Monday");
} else if(day == 2)
{
    Console.WriteLine("Tuesday");
} else if(day == 3)
{
    Console.WriteLine("Wednesday");
} else if(day == 4)
{
    Console.WriteLine("Thursday");
} else if(day == 5)
{
    Console.WriteLine("Friday");
} else if(day == 6)
{
    Console.WriteLine("Saturday");
} else if(day == 7)
{
    Console.WriteLine("Sunday");
} else if(day > 7 || day < 1)
{
    Console.WriteLine("It's not a day of the week, dude!");
}