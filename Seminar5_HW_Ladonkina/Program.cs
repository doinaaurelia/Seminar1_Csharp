/* Задача 34: Задайте массив заполненный случайными
положительными трёхзначными числами. Напишите
программу, которая покажет количество чётных чисел в
массиве.
[345, 897, 568, 234] -> 2 */

void Print(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int[] mass = new int[5];
for (int i = 0; i < mass.Length; i++)
{
    mass[i] = new Random().Next(100, 1000);
}
Print(mass);

int count = 0;
for (int i = 0; i < mass.Length; i++)
{
    if(mass[i] % 2 == 0)
    count++;
}
Console.WriteLine(count);



/////////////////////////////////////////////////////////////////////////////
/////////////////////////////////////////////////////////////////////////////

/* Задача 36: Задайте одномерный массив, заполненный
случайными числами. Найдите сумму элементов, стоящих
на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

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
    mass[i] = new Random().Next(1, 10);
}
Print(mass);

int sum = 0;
for (int i = 0; i < mass.Length; i++)
{
    if(i % 2 == 1)
    sum = sum + mass[i];
}

Console.WriteLine(sum);


/////////////////////////////////////////////////////////////////////////////
/////////////////////////////////////////////////////////////////////////////

/* Задача 38: Задайте массив вещественных чисел. Найдите
разницу между максимальным и минимальным
элементов массива. */

void Print(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
    Console.Write(array[i] + " ");
    }
Console.WriteLine();
}

double[] mass = new double[5];
for (int i = 0; i < mass.Length; i++)
{
    mass[i] = new Random().Next(1, 10) + new Random().NextDouble();
}
Print(mass);

double min = mass[0];
double max = mass[0];
for (int i = 1; i < mass.Length; i++)
{
    if(mass[i] < min)
    {
        min = mass[i];
    }
    else if(mass[i] > max)
    {
        max = mass[i];
    }
}

double diff = max - min;
Console.WriteLine(diff);
