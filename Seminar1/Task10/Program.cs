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
