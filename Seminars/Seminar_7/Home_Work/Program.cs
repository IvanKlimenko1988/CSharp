//Задача №1 - Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

/*
double[,] CreateRandom2dArray()
{
    Console.Write("Input number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input min possitible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input max possitible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
        
    double[,] newArray = new double[rows, columns];

    for(int i = 0; i < rows; i++)   
        for(int j = 0; j < columns; j++)    
            newArray[i,j] = Math.Round(new Random().Next(minValue, maxValue + 1) + new Random().NextDouble(), 1);  

    return newArray; 
}

void Show2dArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write($"[{array[i,j]}] ");

        Console.WriteLine();    
    }

    Console.WriteLine();
}

double[,] newArray = CreateRandom2dArray();
Show2dArray(newArray);
*/
//Задача №2 - Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int[,] myArray = { { 1, 4, 7, 2, }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };


void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }

    Console.WriteLine();
}
void FindElementArray(int[,] array, int indexI, int indexJ)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.WriteLine($"Значение элемента с индексами [{indexI},{indexJ}]: {array[indexI,indexJ]}");
            break;
            //if(i==indexI || j==indexJ) Console.WriteLine($"Значение элемента с индексами [{indexI},{indexJ}]: {array[i,j]}");
            //if(i != indexI || j != indexJ) Console.WriteLine($"{indexJ} --> такого числа в массиве нет");
        }
            
                   
}
Show2dArray(myArray);
Console.Write("imput index [i]: ");
int indexI = Convert.ToInt32(Console.ReadLine());
Console.Write("imput index [j]: ");
int indexJ = Convert.ToInt32(Console.ReadLine());
FindElementArray(myArray, indexI, indexJ);


//Задача №3 - Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.