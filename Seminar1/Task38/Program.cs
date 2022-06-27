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
