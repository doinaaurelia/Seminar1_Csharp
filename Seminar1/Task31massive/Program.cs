/* Задача 31: Задайте массив из 12 эл, заполенный
случайными числами [-9, 9]. Найдите сумму отрицательных и 
положит элементов массива.
 */



void Print(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}

 int[] mass = new int[12];
Print(mass);

 for(int i = 0; i < mass.Length; i++)
 {
     mass[i] = new Random().Next(-9, 10);
 }
 
Print(mass);