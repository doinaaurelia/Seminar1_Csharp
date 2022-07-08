/* Задача 48: Задайте двумерный массив размера 
m на n, каждый элемент в массиве находится по 
формуле: Amn = m+n. Выведите полученный массив на экран.
 
m = 3, n = 4. 0 1 23
1 2 34
2 3 45 */

void Print(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int m = 10, n = 5;
int[,] mass = new int[m, n];
for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i, j] = i + j;
    }
}
Print(mass);
Console.WriteLine();
Print(mass);