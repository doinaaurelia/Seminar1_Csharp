/* Задача 10: Напишите программу, которая принимает на
вход трёхзначное число и на выходе показывает вторую
цифру этого числа.
456 -> 5
782 -> 8
918 -> 1 */

Console.WriteLine("Введите трехзначное число");
int num = int.Parse(Console.ReadLine());

int c12 = num / 10;
int c2 = c12 % 10;

Console.WriteLine(c2);


////////////////////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////////////////

/* Задача 15: Напишите программу, которая принимает на
вход цифру, обозначающую день недели, и проверяет,
является ли этот день выходным.
6 -> да
7 -> да
1 -> нет */

Console.WriteLine("Введите цифру, обозначающую день недели");
int day = int.Parse(Console.ReadLine());

if(day <= 8 && day > 0)
{
    if(day == 6 || day == 7)
    {
        Console.WriteLine("Да! Праздничек!"); 
    }   
    else {
        Console.WriteLine("Нет, иди работай!");
    }
} 
else {
    Console.WriteLine("Чувак, в неделе всего 7 дней!");
}


