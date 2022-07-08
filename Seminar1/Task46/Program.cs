/* Задача 46: Задайте двумерный массив размером m×n, 
заполненный случайными целыми числами.
m = 3, n = 4. 1 4 8 19
5 -2 33 -2 77 3 8 1 */


void Print(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int m = 3, n = 4;
int[,] mass = new int[m, n]; // двумерный массив [ [1,2,3,4] , [5,6,7,8] , [1,3,6,7] ]
for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i, j] = new Random().Next(0, 10);
        Console.Write(mass[i, j] + " ");
        
    }
    Console.WriteLine();
} 

Print(mass);
Console.WriteLine();
Print(mass);
