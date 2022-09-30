using System;
using static System.Console;

//Task 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8
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

void Sort2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = j + 1; k < array.GetLength(1); k++)
                if (array[i, k] > array[i, j])
                {
                    int temp = array[i, j];
                    array[i, j] = array[i,k];
                    array[i,k] = temp;
                }
        }   
    }
}

Clear();
Write("Введите количество строк массива: ");
int rows = Convert.ToInt32(ReadLine());
Write("Введите количество столбцов массива: ");
int columns = Convert.ToInt32(ReadLine());
int[,] new2DArray = CreateRandom2DArray(rows, columns);
Show2DArray(new2DArray);
Sort2DArray(new2DArray);
WriteLine();
Show2DArray(new2DArray);
*/
//Task 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
/*
int[,] GetArray(int rows, int columns, int min, int max)
{
    int[,] resultArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            resultArray[i, j] = new Random().Next(min, max + 1);
    return resultArray;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Write(array[i, j] + " ");
        WriteLine();
    }
}

int FindSumElementsRos(int[,] array)
{
    int row = 0;
    int sum = 0;
    for(int i = 0; i < array.GetLength(1); i++)
        sum += array[0,i];
    for(int i = 0; i < array.GetLength(0); i++)
    {
        int minSum = 0;
        for(int j = 1; j < array.GetLength(1); j++)
        {
            minSum +=array[i,j];
        }
        if(sum > minSum)
        {
            sum = minSum;
            row = i;
        }
    }
    return row;
}
Clear();
Write("Введите количество строк и столбов через пробел: ");
string[] nums = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
int[,] newArray = GetArray(int.Parse(nums[0]), int.Parse(nums[1]), 1, 30);
PrintArray(newArray);
WriteLine($"Строка с наименьшей суммой -> {FindSumElementsRos(newArray)}");
*/
//Task 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, заданы 2 массива:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// и
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7
// Их произведение будет равно следующему массиву:
// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49
/*
int[,] GetArray(int rows, int columns, int min, int max)
{
    int[,] resultArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            resultArray[i, j] = new Random().Next(min, max + 1);
    return resultArray;
}

void MulArray(int[,] array1, int[,] array2)
{
    int row1 = array1.GetLength(0);
    int col1 = array1.GetLength(1);
    int row2 = array2.GetLength(0);
    int col2 = array2.GetLength(1);
    
    if(col1 == row2)    //Условие умножения 2-х матриц: количество столбцов певрой матрицы
    {                   // должно быть равно количеству строк второй матрицы.
        int[,] mulArray = new int[row1, col2];               
        for(int i = 0; i < row1; i++)   //Внешний цикл переберает все строки первой матрицы.
            for(int j = 0; j < col2; j++)   // Первый вложённый переберает все столбыцы второй матрицы. 
            {                               //Так как результирующая матрица состоит из количесвта строк первой матрицы и количесвто столбцов второй матрицы.
                mulArray[i, j] = 0;         //Перед циклом обнуляем сумму, следующего вложенного цикла
                for (int k = 0; k < col1; k++)  //Цикл перебирает все столбцы первой матрицы. Можно было бы указать в условии строки второй матрицы.
                    mulArray[i, j] += array1[i, k] * array2[k, j];  //Вычисление и запись суммы произведений двух матриц.
            }

        WriteLine("Произведение двух матриц: ");

        for (int i = 0; i < row1; i++)
            {
                 for (int j = 0; j < col2; j++)
                Write(mulArray[i, j] + " ");

                WriteLine();
            }

            WriteLine();
    }
    else Console.WriteLine("Количество столбцов певрой матрицы должно быть равно количеству строк второй матрицы!");    
}

Clear();
Write("Введите количество строк и столбов первой матрицы через пробел: ");
string[] nums1 = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
int[,] newArray1 = GetArray(int.Parse(nums1[0]), int.Parse(nums1[1]), 1, 30);
Write("Введите количество строк и столбов второй матрицы через пробел: ");
string[] nums2 = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
int[,] newArray2 = GetArray(int.Parse(nums2[0]), int.Parse(nums2[1]), 1, 30);
MulArray(newArray1, newArray2);
*/
//Task 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// массив размером 2 x 2 x 2
// 12(0,0,0) 22(0,0,1)
// 45(1,0,0) 53(1,0,1)
/*
bool FindNumberInArray(int[,,] array, int number)  //Метод для поиска числа в массиве.
{                                           //Перебираем весь массив и если число есть, 
    bool findNumber = false;                //то возвращаем true(элемент есть в массиве).  
    for(int i = 0; i < array.GetLength(0); i++)
        for(int j = 0; j < array.GetLength(1); j++)
            for(int k = 0; k < array.GetLength(2); k++)
                if(array[i, j, k] == number)
                    findNumber = true;
            
    return findNumber;
}

int[,,] CreateRandom3dArray()
{
Console.Write("Input number of array: ");
int width = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of rows array: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number ofint columns array: ");
int columns = Convert.ToInt32(Console.ReadLine());

Console.Write("Input min possitible value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possitible value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,,] newArray = new int[width, rows, columns];

for (int i = 0; i < width; i++)
    for (int j = 0; j <rows; j++)
        {
            int k = 0;
            while(k < columns)  //Цикл для генерирования неповторяющихся чисел и записи в массив.
            {
                int randomNumber = new Random().Next(minValue, maxValue + 1);
                if(FindNumberInArray(newArray, randomNumber)) continue; //Если число нашлось в массиве, пропускаем строчки 233 и 234!
                newArray[i, j, k] = randomNumber;                       //Пробуем снова сгенирировать число и выполнить проверку.
                k++;
            }
        }             
return newArray;            
}
 
void Show3dArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write($"Array number №{(i + 1)}, size array: {array.GetLength(0)}");
        Console.WriteLine($" x {array.GetLength(1)} x {array.GetLength(2)}");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for(int k = 0; k < array.GetLength(2); k++)
                Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
            Console.WriteLine();    
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,,] newArray = CreateRandom3dArray();
Show3dArray(newArray);
*/
//Task 62: Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7

int[,] GetArray(int size)
{
    int[,] array = new int[size, size];
    int i = 0;
    int j = 0;
    int rowEnd = size - 1;
    int colEnd = size - 1;
    int rowStart = 0;
    int colStart = 0;
    bool left = true;
    bool top = true;
    int count = 0;

    while (count < size * size)
    {
        count++;
        array[i, j] = count;
        //Идём вправо
        if (left && top)
        {
            if (j == colEnd)
            {
                rowStart++;
                top = true;
                left = false;
                i++;
                continue;
            }
            else
            {
                j++;
                continue;
            }
        }
        //Идём вниз
        if (!left && top)
        {
            if (i == rowEnd)
            {
                colEnd--;
                top = false;
                left = false;
                j--;
                continue;
            }
            else
            {
                i++;
                continue;
            }
        }
        //Идёи влево
        if (!left && !top)
        {
            if (j == colStart)
            {
                rowEnd--;
                top = false;
                left = true;
                i--;
                continue;
            }
            else
            {
                j--;
                continue;
            }
        }
        //Идём вверх
        if (left && !top)
        {
            if (i == rowStart)
            {
                colStart++;
                top = true;
                left = true;
                j++;
                continue;
            }
            else
            {
                i--;
                continue;
            }
        }
    }
return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Write(array[i, j] + " ");

        WriteLine();
    }
    WriteLine();
}

Clear();
Write("Введите размер матрицы: ");
int size = int.Parse(ReadLine());
int[,] newArray = GetArray(size);
Show2dArray(newArray);