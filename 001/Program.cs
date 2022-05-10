//Задача 1
//Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

int[] array = new int[7];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100, 999);
    Console.Write(array[i] + " ");
}

int count = 0;
for (int j = 0; j < array.Length; j++)
{
    if (array[j] % 2 == 0)
    {
        count = count + 1;
    }
}
Console.WriteLine();
Console.WriteLine("Even numbers:" + count);