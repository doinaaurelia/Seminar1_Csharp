 /* Задача 25: Напишите цикл, который 
принимает на вход два числа (A и B) и 
возводит число A в натуральную степень B. 

int num1 = 2;
int num2 = 3;

for(int i = num1; i <= num1; i++) {
    for (int j = num2; j <= num2; j++) {
        Console.WriteLine(Math.Pow(num1, num2));
    }
} */


//---------------------------------------------------------------

/* Задача 27: Напишите программу, которая принимает на вход 
число и выдаёт сумму цифр в числе.
452 -> 11 
82 -> 10 
9012 -> 12 */

// 
/* 
Console.WriteLine("Введите число: ");
string number = Console.ReadLine();
int sum = 0;

for(int i = 0; i < number.Length; i++)
{
    sum = sum + int.Parse(number[i].ToString());
    
}

Console.WriteLine(sum);

 */

//Console.WriteLine(number);

//---------------------------------------------------------------

/* Задача 29: Напишите программу, которая задаёт 
массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19] 
6, 1, 33 -> [6, 1, 33] */

void Print(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
     Console.Write(array[i] + " ");   
    }
    Console.WriteLine();
}

int[] mass = new int[8];
for (int i = 0; i < mass.Length; i++)
{
    mass[i] = new Random().Next(1, 100);
}
Print(mass);