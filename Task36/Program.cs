//Задача 36: Задайте одномерный массив, 
//заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

using static System.Console;
Clear();

int[] array = new int[10]; 
int SumOfNumbers = 0;
WriteLine("Числа массива:");
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 100);
    Write(array[i] + " ");
}
for (int j = 1; j < array.Length; j+=2)
{                                       
    SumOfNumbers += array[j];
}
WriteLine();
WriteLine($"Сумма чисел с нечетными индексами: {SumOfNumbers}");