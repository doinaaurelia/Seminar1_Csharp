/* Task 35
Создайте массив из 123 случайных числе.
Найдите количество элементов массива, значения которых лежат в 
отрезке [10, 99].
 */
//Задаем массив
void Print(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}
Console.WriteLine();

int[] mass = new int[123];
for (int i = 0; i < mass.Length; i++)
{
    mass[i] = new Random().Next(0, 200);
}
Print(mass);
Console.WriteLine();

// 
int count = 0;
for (int i = 0; i < mass.Length; i++)
{
    if(mass[i] < 100 && mass[i] > 9)
    count++;

}
Console.WriteLine("Количество " + count);

// stopped video at 1:31