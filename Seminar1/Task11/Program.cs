/* 11. Напишите программу, которая выводит 
случайное трёхзначное число и удаляет 
вторую цифру этого числа.
  456 -> 46 
  782 -> 72 
  918 -> 98 */

int num = new Random().Next(100, 1000);

int c1 = num / 100;
int c3 = num % 10;



Console.WriteLine(num); 
Console.WriteLine($"{c1}{c3}"); 
