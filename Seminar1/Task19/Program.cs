/* Задача 19: Напишите программу, которая 
принимает на вход пятизначное число и 
проверяет, является ли оно палиндромом. 
14212 -> нет 
23432 -> да 
12821 -> да*/

/* int num = new Random().Next(10000, 100000); */

int num = 12321;
Console.WriteLine(num);

int c1 = num / 10000;
int c12 = num / 1000;
int c2 = c12 % 10;
int c1234 = num / 10;
int c4 = c1234 % 10;
int c5 = num % 10;


if(c1 == c5)
{
    if(c2 == c4)
    {
        Console.WriteLine("Это палиндром!");
    }
}
else
{
    Console.WriteLine("Это не палиндром");
}

