/* Задача 28: Напишите программу, которая 
принимает на вход число N и выдаёт произведение 
чисел от 1 до N.
 
4 -> 24 5 -> 120

 */

/* Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine());

int count = 1;
int result = 1;

while (count <= N)
{
    result = result * count;
    count++;
}
Console.WriteLine(result); */

///////////
int Fact(int num)
{
    int count = 1;
    int result = 1;

    while (count <= num)
    {
    
        result = result * count;
        count++;
    }
    return res;

    }
    Console.WriteLine("Введите число: ");
    int num = int.Parse(Console.ReadLine());


Console.WriteLine(Fact(N));

/* int Fact(int num)
{
    int count = 1;
    int res = 1;

    while (count <= num)
    {
        res = res * count;
        count++;
    }
    return res;
}

Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine());

Console.WriteLine(Fact(N)); */