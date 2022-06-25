/* Task 32
Написать программу замену элементов массива: 
положительные элементы щаменить на соответ. отрицательные
и наоборот. */

void Print(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
    Console.Write(array[i] + ", ");
    }   
Console.WriteLine();
}


int[] mass = new int[6];
for (int i = 0; i < mass.Length; i++)
{
    mass[i] = new Random().Next(-5, 6);
}
Print(mass);

// Преобразование

for (int i = 0; i < mass.Length; i++)
{
    mass[i] = mass[i] * -1;
}

Print(mass);