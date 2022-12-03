//Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным 
//и минимальным элементов массива.

//[3 7 22 2 78] -> 76


using static System.Console;
Clear();

double[] array = new double[10];
WriteLine("Числа массива:");
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 100);
    Write(array[i] + " ");
}
WriteLine();
WriteLine($"Разница между первым и последним элементами = {Math.Abs(array[0] - array[array.Length - 1])}");