using System;
using static System.Console;
//Task 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
/*
double[,] CreateRandom2DArray(int rows, int columns)
{
    Write("Введите минимальное возможное значение элемента массива: ");
    int minValue = Convert.ToInt32(ReadLine());
    Write("Введите максимальное возможное значение элемента массива: ");
    int maxValue = Convert.ToInt32(ReadLine());
    double[,] array2D = new double[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array2D[i, j] = new Random().Next(minValue, maxValue + 1) + new Random().NextDouble();
    return array2D;
}

void Show2DArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Write($"{array[i, j]:f2} ");
        }
        WriteLine();
    }
}
Clear();
Write("Введите количество строк массива: ");
int rows = Convert.ToInt32(ReadLine());
Write("Введите количество столбцов массива: ");
int columns = Convert.ToInt32(ReadLine());
double[,] new2DArray = CreateRandom2DArray(rows, columns);
Show2DArray(new2DArray);
*/
//Task 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
/*
int[,] CreateRandom2DArray(int rows, int columns)
{
    Write("Введите минимальное возможное значение элемента массива: ");
    int minValue = Convert.ToInt32(ReadLine());
    Write("Введите максимальное возможное значение элемента массива: ");
    int maxValue = Convert.ToInt32(ReadLine());
    int[,] array2D = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array2D[i, j] = new Random().Next(minValue, maxValue + 1);
    return array2D;
}

void Show2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Write(array[i, j] + " ");
        }
        WriteLine();
    }
    
}

void PrintElementOf2DArray(int[,] array, int indexI, int indexJ)
{
    if(indexI > array.GetLength(0) - 1 || indexJ > array.GetLength(1) - 1)
       WriteLine($"{indexI}{indexJ} -> такого числа в массиве нет");
    else
    {
        WriteLine(array[indexI, indexJ]);
    }
}

Clear();
Write("Введите количество строк массива: ");
int rows = Convert.ToInt32(ReadLine());
Write("Введите количество столбцов массива: ");
int columns = Convert.ToInt32(ReadLine());
int[,] new2DArray = CreateRandom2DArray(rows, columns);
Show2DArray(new2DArray);

Write("Введите первый индекс элемента массива: ");
int indexI = Convert.ToInt32(ReadLine());
Write("Введите введите второй индекс массива: ");
int indexJ = Convert.ToInt32(ReadLine());
PrintElementOf2DArray(new2DArray, indexI, indexJ);
*/
//Task 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] CreateRandom2DArray(int rows, int columns)
{
    Write("Введите минимальное возможное значение элемента массива: ");
    int minValue = Convert.ToInt32(ReadLine());
    Write("Введите максимальное возможное значение элемента массива: ");
    int maxValue = Convert.ToInt32(ReadLine());
    int[,] array2D = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array2D[i, j] = new Random().Next(minValue, maxValue + 1);
    return array2D;
}

void Show2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Write(array[i, j] + " ");
        }
        WriteLine();
    }

}

void GetArithmeticMeanColumns(int[,] array)
{
    double sum = 0;
    double result = 0;

    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sum += array[j, i];

        }
        result = sum / array.GetLength(0);
        Write($"{result:f2} ");
        sum = 0;
    }
}


Clear();
Write("Введите количество строк массива: ");
int rows = Convert.ToInt32(ReadLine());
Write("Введите количество столбцов массива: ");
int columns = Convert.ToInt32(ReadLine());
int[,] new2DArray = CreateRandom2DArray(rows, columns);
Show2DArray(new2DArray);
GetArithmeticMeanColumns(new2DArray);
