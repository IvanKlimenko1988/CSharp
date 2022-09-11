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
//Решение 1 - Если задан массив
/*
int[,] myArray = { { 1, 4, 7, 2, }, 
                   { 5, 9, 2, 3 }, 
                   { 8, 4, 2, 4 } };

void FindElementArray(int indexI, int indexJ)
{
    if(indexI > myArray.GetLength(0) - 1 || indexJ > myArray.GetLength(1)- 1)
        Console.WriteLine($"Элемента с позицией [{indexI},{indexJ}] нет в массиве.");
    for (int i = 0; i < myArray.GetLength(0); i++)
        for (int j = 0; j < myArray.GetLength(1); j++)
            if(i==indexI && j==indexJ) 
                Console.WriteLine($"Значение элемента с позицией [{indexI},{indexJ}]: {myArray[i,j]}");          
}

Console.Write("Введите позицию элемента в строке: ");
int indexI = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите позицию элемента в столбце: ");
int indexJ = Convert.ToInt32(Console.ReadLine());
FindElementArray(indexI, indexJ);
*/
//Решение 2 - Универсальный метод
/*
int[,] CreateRandom2dArray()
{
    Console.Write("Input number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input min possitible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input max possitible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
        
    int[,] newArray = new int[rows, columns];

    for(int i = 0; i < rows; i++)   
        for(int j = 0; j < columns; j++)   
            newArray[i,j] = new Random().Next(minValue, maxValue + 1); 

    return newArray; 
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();    
    }

    Console.WriteLine();
}

void FindElementArray(int[,] array, int indexI, int indexJ)
{
    if(indexI > array.GetLength(0) - 1 || indexJ > array.GetLength(1)- 1)
        Console.WriteLine($"Элемента с позицией [{indexI},{indexJ}] нет в массиве.");
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            if(i==indexI && j==indexJ) 
                Console.WriteLine($"Значение элемента с позицией [{indexI},{indexJ}]: {array[i,j]}");          
}
int[,] newArray = CreateRandom2dArray();
Show2dArray(newArray);

Console.Write("Введите позицию элемента в строке: ");
int indexI = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите позицию элемента в столбце: ");
int indexJ = Convert.ToInt32(Console.ReadLine());

FindElementArray(newArray, indexI, indexJ);
*/



//Задача №3 - Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();    
    }

    Console.WriteLine();
}

void FindAverageSum(int[,] array)
{
    double sum = 0;
    double avarSum = 0;
    Console.Write("Среднее арифметическое каждого столбца: ");
    for(int i = 0; i < array.GetLength(1); i++)
    {
        for(int j = 0; j < array.GetLength(0); j++)
            {
                sum += array[j,i];
            }
        
        avarSum = Math.Round((sum / array.GetLength(0)) , 2);
        sum = 0;
        Console.Write(avarSum + " ");
        avarSum = 0;
    }
              
}
int[,] myArray =  {{ 1, 4, 7, 2,}, 
                   { 5, 9, 2, 3 }, 
                   { 8, 4, 2, 4 }};


Show2dArray(myArray);
FindAverageSum(myArray);
