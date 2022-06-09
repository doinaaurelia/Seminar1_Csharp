/* Напишите программу, которая принимает на вход 
трёхзначное число и на выходе показывает 
последнюю цифру этого числа.
456 -> 6 782 -> 2 918 -> 8
  */

/* int n = 1003;

if(n > 99 & n < 1000)
{
Console.WriteLine(n);
Console.WriteLine(n % 10);
} 
else
{
    Console.WriteLine("Not really correct");
}
 */

 int n = 123;
 string str = n.ToString();

Console.WriteLine(n); 
Console.WriteLine(str[2]);

