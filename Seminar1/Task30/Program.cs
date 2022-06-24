/* Задача 30: Напишите программу, которая выводит 
массив из 8 элементов, заполненный нулями и 
единицами в случайном порядке.
 [1,0,1,1,0,1,0,0] */

 //int numberA = new Random().Next(1, 10);


int[] array = new int[8];

int i = 0;

while(i < array.Length)
{
    Console.Write(array[i] = new Random().Next(0, 2));
    i++;
}
Console.WriteLine();


/* 
void PrintArray(int[] col)
{
    for (int i = 0; i < mass.Length; i++)
    {
         Console.Write(mass[i] + " ");
    }
    Console.WriteLine();
}

PrintArray(mass); */