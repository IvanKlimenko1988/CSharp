//Задача №1 - Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
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

    for(int i = 0; i < rows; i++)   // Можно записать условие цикла иначе: i < newArray.GetLenght(0);
        for(int j = 0; j < columns; j++)    //j < newArray.GetLenght(1);
            newArray[i,j] = new Random().Next(minValue, maxValue + 1);  //Заполняем случайными числами массив.

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

int[,] newArray = CreateRandom2dArray();
Show2dArray(newArray);
*/
//Задача №2 - Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aij = i+j. Выведите полученный массив на экран.
/*
int[,] Create2dArray()
{
    Console.Write("Input number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    
    int[,] newArray = new int[rows, columns];

    for(int i = 0; i < rows; i++)   
        for(int j = 0; j < columns; j++)    
            newArray[i,j] = i + j;  

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

int[,] newArray = Create2dArray();
Show2dArray(newArray);
*/
//Задача №3 - Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

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

void SquaredEvenIndex(int[,] array)   //Метод, который возводит в квадрат элементы с четными индексами входящего массива
{
    for(int i = 0; i < array.GetLength(0); i+= 2)
        for(int j = 0; j < array.GetLength(1); j+= 2)
            array[i,j] = array[i,j] * array[i,j];
}

int[,] newArray = CreateRandom2dArray();
Show2dArray(newArray);
SquaredEvenIndex(newArray);
Show2dArray(newArray);

//Задача №4 - Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
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

int sumMainDiag(int[,] array)
{
    int sum = 0;
    for(int i = 0; i < array.GetLength(0) && i < array.GetLength(1);i++)
        sum += array[i,i];

    return sum;
}

int[,] newArray = CreateRandom2dArray();
Show2dArray(newArray);
int sumDiag = sumMainDiag(newArray);
Console.Write($"Сумма элементов главной диагонали: {sumDiag}"); //Если в массиве количество строк отличается от столбцов, то диагональ упирается в элемент в последний строчке.
*/