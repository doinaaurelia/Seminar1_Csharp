/* Задача 31: Задайте массив из 12 эл, заполенный
случайными числами [-9, 9]. Найдите сумму отрицательных и 
положит элементов массива.
 */


// Вывод элементов массива
void Print(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}

// Напомнили массив количеством элементов и задали промежуток
 int[] mass = new int[12];


 for(int i = 0; i < mass.Length; i++)
 {
     mass[i] = new Random().Next(-9, 10);
 }
 
Print(mass);

// Нашли сумму положит и отрицательных элементов
int sumNeg = 0;
int sumPos = 0;
for (int i = 0; i < mass.Length; i++)
{
    if(mass[i] > 0)
    {
        sumPos += mass[i];
    }   else
    {
        sumNeg += mass[i];
    }
}

Console.WriteLine(sumPos);
Console.WriteLine(sumNeg);
