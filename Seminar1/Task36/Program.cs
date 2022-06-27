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