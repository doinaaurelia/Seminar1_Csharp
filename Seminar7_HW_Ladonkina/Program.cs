/* Задача 47: Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами. 

void Print(double[,] arr)
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
double [,] mass = new double [m, n];
for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i, j] = (i+j) * 0.8;
    }
}
Print(mass); */

/////////////////////////////////////////////////////
/////////////////////////////////////////////////////

/* Задача 50: Напишите программу, которая на 
вход принимает позиции элемента в двумерном 
массиве, и возвращает значение этого элемента 
или же указание, что такого элемента нет. */

/* void Print(int[,] arr)
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
int [,] mass = new int [m, n];
for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i, j] = new Random().Next(0, 10);
    }
}
Print(mass); 

Console.WriteLine("Впишите номер строки");
int row = int.Parse(Console.ReadLine());
if(row > mass.GetLength(0) 
   || row < 0)
   {
       Console.WriteLine("Такой позиции нет");
       return;
   }

Console.WriteLine("Введите номер столбца");
int column = int.Parse(Console.ReadLine());
if(column > mass.GetLength(1)
   || column < 0)
   {
       Console.WriteLine("Такой позиции нет");
       return;
   } 

Console.WriteLine(mass[row, column]); */


/////////////////////////////////////////////////////
/////////////////////////////////////////////////////

/* Задача 52: Задайте двумерный массив из 
целых чисел. Найдите среднее арифметическое 
элементов в каждом столбце. */

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
int [,] mass = new int [m, n];
for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i, j] = new Random().Next(0, 10);
    }
}
Print(mass); 

double column1 = 0;
double column2 = 0;
double column3 = 0;
double column4 = 0;

for (int i = 0; i < mass.GetLength(0); i++)
{
    column1 = column1 + mass[i, 0];
    column2 = column2 + mass[i, 1];
    column3 = column3 + mass[i, 2];
    column4 = column4 + mass[i, 3];

    
    
}
Console.WriteLine($"{column1/mass.GetLength(0)}, {column2/mass.GetLength(0)}, {column3/mass.GetLength(0)}, {column4/mass.GetLength(0)}");