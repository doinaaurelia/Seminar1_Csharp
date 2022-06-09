/* Задача 4: Напишите программу, которая принимает на вход 
три числа и выдаёт максимальное из этих чисел. */

Console.WriteLine("Введние первое число");
int n1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введние второе число");
int n2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введние третье число");
int n3 = int.Parse(Console.ReadLine());

int maxn = n1;

if(n2 > n1 & n2 > n3)
{
    maxn = n2;
} else if(n3 > n1 & n3 > n2)
{
    maxn = n3;
}

Console.WriteLine("Самое больше число " + maxn);