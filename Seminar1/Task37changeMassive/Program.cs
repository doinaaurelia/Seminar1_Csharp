/* Задача 37: Найдите произведение пар чисел в 
одномерном массиве. Парой считаем первый и 
последний элемент, второй и предпоследний
и т.д. Результат запишите в новом массиве. 
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21 */
 
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
     mass[i] = new Random().Next(1, 100);
 }
 Print(mass);


int j = 0;
int[] array = new int[mass.Length / 2];
while(j < mass.Length /2 )
{
    array[j] = mass[j] * mass[mass.Length - j - 1];
    j++;
}
array[array.Length-1] = mass[mass.Length /2];
Print(array);