using System;
using static System.Console;

//Task 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
/*
int[] GetRandomArray()
{
    Write("Введите размер массива: ");
    int size = int.Parse(ReadLine());
    int[] randomArray = new int[size];
    for (int i = 0; i < size; i++)
        randomArray[i] = new Random().Next(100, 1000);
    return randomArray;
}

int GetEvenNumbers(int[] array)
{
    int count = 0;
    foreach (int item in array)
    {
        if (item % 2 == 0) count++;
    }
    return count;
}
Clear();
int[] randomArray = GetRandomArray();
int sumEvenNumbers = GetEvenNumbers(randomArray);
Write(String.Join(", ", randomArray));
Write($" -> {sumEvenNumbers}");
*/
//Task 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
/*
int[] GetRandomArray()
{
    Write("Введите размер массива: ");
    int size = int.Parse(ReadLine());
    Write("Введите минимальное значение элемента: ");
    int minValue = int.Parse(ReadLine());
    Write("Введите максимальное значение элемента: ");
    int maxValue = int.Parse(ReadLine());
    int[] randomArray = new int[size];
    for (int i = 0; i < size; i++)
        randomArray[i] = new Random().Next(minValue, maxValue + 1);
    return randomArray;
}

int GetSumNumbersForOddIndex(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i = i + 2)
    {
        sum += array[i];
    }
    return sum;
}
Clear();
int[] randomArray = GetRandomArray();
int sumOddIndex = GetSumNumbersForOddIndex(randomArray);
Write(String.Join(", ", randomArray));
Write($" -> {sumOddIndex}");
*/
//Task 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] GetRandomArray()
{
    Write("Введите размер массива: ");
    int size = Convert.ToInt32(ReadLine());
    Write("Введите минимальное значение элемента: ");
    int minValue = Convert.ToInt32(ReadLine());
    Write("Введите максимальное значение элемента: ");
    int maxValue = Convert.ToInt32(ReadLine());
    double[] randomArray = new double[size];
    for (int i = 0; i < size; i++)
        randomArray[i] = new Random().Next(minValue, maxValue + 1) + new Random().NextDouble();
    return randomArray;
}

double GetDiffMaxMinElements(double[] array)
{
    double max = array[0];
    double min = array[0];
    foreach (double item in array)
    {
        if(item > max) max = item;
        if(item < min) min = item;
    }
    return max - min;
}

void ShowArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
        Write($"[{array[i]:f2}] ");
    WriteLine();    
}   
Clear();
double[] randomArray = GetRandomArray();
double diff = GetDiffMaxMinElements(randomArray);
ShowArray(randomArray);
WriteLine($"Разница между максимальным и минимальным элементом массива = {diff:f2}");