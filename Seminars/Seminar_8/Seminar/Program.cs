//Задача №1 - Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
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

void ChangeRows(int[,] array, int row1, int row2)
{
    if(row1 >= 0 && row1 < array.GetLength(0) && row2 >= 0 && row2 < array.GetLength(0) && row1 != row2)
        for(int j = 0; j < array.GetLength(1); j++)
        {
            int temp = array[row1, j];
            array[row1, j] = array[row2, j];
            array[row2, j] = temp;
        }

}

int[,] newArray = CreateRandom2dArray();
Show2dArray(newArray);
ChangeRows(newArray, 0, 1);
Show2dArray(newArray);
*/
//Задача №2 - Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.
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

void SwitchRowsColumns(int[,] array)
{
    if(array.GetLength(0) == array.GetLength(1))    //Проверка на квадратную матрицу.
        for(int i = 0; i < array.GetLength(0)-1; i++)   //Внешний цикл идёт до предпоследнего элемента строки, так как последний элемент остаётся на своём месте.
            for(int j = 1; j < array.GetLength(1); j++) //Вложенный цикл начинается со второго элемента в столбце, так как первый остаётся на своём месте.
            {
                int temp = array[i,j];  //В цикле идёт замена элементов местами.
                array[i,j] = array[j,i];
                array[j,i] = temp;
            }
    else 
    {
        Console.WriteLine("В массиве невозможно заменить строки на столбцы.");
        Console.WriteLine();
    }
    
}

int[,] newArray = CreateRandom2dArray();
Show2dArray(newArray);
SwitchRowsColumns(newArray);
Show2dArray(newArray);
*/
//Задача №3 - Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент.

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

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);

    return newArray;
}

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

int[,] RemoveMinElement(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    int[,] new2dArray = new int[rows - 1, columns - 1];
    int minIndexI = 0;
    int minIndexJ = 0;
    int minVal = array[0, 0];
    

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            if (minVal > array[i, j])
            {
                minVal = array[i,j];
                minIndexI = i;
                minIndexJ = j;
            }
        }

    }

    int m = 0;
    for (int i = 0; i < rows; i++)
    {
        if (i == minIndexI) continue;
        int n = 0;
        for (int j = 0; j < columns; j++)
        {
            if (j == minIndexJ) continue;
            new2dArray[m, n] = array[i, j];
            n++;
        }
        m++;
    }

    return new2dArray;

}

int[,] newArray = CreateRandom2dArray();
Show2dArray(newArray);
int[,] RemoveArray = RemoveMinElement(newArray);
Show2dArray(RemoveArray);

//Задача №4 - Написать программу поэлементного копирования массива.
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

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);

    return newArray;
}

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

int[,] CopyArray(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    int[,] new2dArray = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            new2dArray[i, j] = array[i, j];

    return new2dArray;

}

int[,] newArray = CreateRandom2dArray();
Show2dArray(newArray);
int[,] copyArray = CopyArray(newArray);
Show2dArray(copyArray);
*/