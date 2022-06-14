/* Напишите программу, которая принимает на вход 
число и проверяет, кратно ли оно 
одновременно 7 и 23.
  
14 -> нет 
46 -> нет 
161 -> да */

Console.WriteLine("Введите число");
int n = int.Parse(Console.ReadLine());

if(n % 161 == 0)
{
    Console.WriteLine("да");
} 
else {
    Console.WriteLine("нет");
}