//Задача 34: Задайте массив заполненный случайными 
//положительными трёхзначными числами. Напишите программу, 
//которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2


using static System.Console;
Clear();


WriteLine("Трёхзначные числа массива:");
int[] array = new int[10];
int counter = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100, 1000);
    Write(array[i] + " ");
}
for (int j = 0; j < array.Length; j++)
{
    if (array[j] % 2 == 0)
        counter += 1;
}
WriteLine();
WriteLine($"Четных чисел в массиве: {counter}");
