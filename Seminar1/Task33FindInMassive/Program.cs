/* Task 33: Задайте массив. Напишите программу, которая определяет,
присутствует ли элементе в массиве. */

void Print(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
    Console.Write(array[i] + " ");
    }
Console.WriteLine();
}

int[] mass = new int[5];
for (int i = 0; i < mass.Length; i++)
{
    mass[i] = new Random().Next(-5, 6);
}

Print(mass);

Console.WriteLine("Введите число");
int yourNum = int.Parse(Console.ReadLine());
string yesOrNo = "No";
for (int i = 0; i < mass.Length; i++)
{
    if(yourNum == mass[i])
    {
        yesOrNo = "Yes";
    }
}
Console.WriteLine(yesOrNo);