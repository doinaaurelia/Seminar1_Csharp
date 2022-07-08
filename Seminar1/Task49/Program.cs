/* Задача 49: Задайте двумерный массив. Найдите элементы, у
которых оба индекса чётные, и замените эти элементы на их
квадраты. */

void Print(int[,] arr)
{
for (int i = 0; i < arr.GetLength(0); i++)
{
for (int j = 0; j < arr.GetLength(1); j++)
{
Console.Write(arr[i, j] + "\t"); // \t - табуляция, двойной отступ
}
Console.WriteLine();
}

}
int m = 3, n = 4;
int[,] mass = new int[m, n];

    for (int i = 0; i < mass.GetLength(0); i++) // перебирает каждый элемент массива в строке
    {
        for (int j = 0; j < mass.GetLength(1); j++) // перебирает каждый элемент столбца
        {
        mass[i, j] = new Random().Next(0, 10);
        }
}

Print(mass);
Console.WriteLine();

    for (int i = 0; i < mass.GetLength(0); i = i+2) // i = i+2 перебирает каждый четный элемент массива в строке
    {
        for (int j = 0; j < mass.GetLength(1); j = j+2) // j = j+2 перебирает каждый четный элемент столбца
        {
        mass[i, j] = mass[i, j] * mass[i, j];
        }
    }

Print(mass);