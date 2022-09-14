//Задача №1 -  Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
//Пузырьковая сортировка(сортировка внутри двумерного массива).
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

void SortMaxToMinArray(int[,] array)    //Метод для сортировки массива
{
    for (int i = 0; i < array.GetLength(0); i++)                //Итерация цикла идет по строкам массива. 
        for (int j = 0; j < array.GetLength(1); j++)            //Первый вложенный цикл идёт по столбцам.
            for (int k = j + 1; k < array.GetLength(1); k++)    //Внутренний цикл, сортирует массив по условию.
                if (array[i, j] < array[i, k])                  //Если первый элемент в строке меньше второго,
                {                                               //то меняем их местами.
                    int temp = array[i, j];
                    array[i, j] = array[i, k];
                    array[i, k] = temp;
                }
}

int[,] newArray = CreateRandom2dArray();
Show2dArray(newArray);
SortMaxToMinArray(newArray);
Show2dArray(newArray);
*/
//Задача №2 - Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
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

int[] FindMinSumRow(int[,] array)

{
    int sum = 0;
    int [] sumRows = new int[array.GetLength(0)];
    for(int i = 0; i < array.GetLength(0); i++)
    {   
        for(int j = 0; j < array.GetLength(1); j++)
            {
                sum += array[i, j];
            }
        Console.WriteLine($"Сумма строки {i + 1}: {sum}");
        sumRows[i] = sum;
        sum = 0;
    }
    return sumRows;
}
 
void ShowMinSumRow(int[] array)
{
    int min = array[0];
    int row = 1;
    for( int i = 0; i < array.Length; i++)
        if(array[i] < min)
        {
            min = array[i];
            row = i + 1;
        }   

    Console.WriteLine("Строка с наименьшей суммой элементов: " + row);    
}

int[,] newArray = CreateRandom2dArray();
Show2dArray(newArray);
int[] myArr = FindMinSumRow(newArray);
ShowMinSumRow(myArr);
*/
//Задача №3 - Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц. Почитать стороннюю информацию, ресурс MathProfi где поискать
// 
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

void MulArray(int[,] array1, int[,] array2)
{
    int row1 = array1.GetLength(0);
    int col1 = array1.GetLength(1);
    int row2 = array2.GetLength(0);
    int col2 = array2.GetLength(1);
    int mul = 0;
    int mu2 = 0;
    int mu3 = 0;
    int mu4 = 0;
    int sum1 = 0;
    int sum2 = 0;
    if(col1 == row2)
        {
            int[,] mulArray = new int[row1, col2];
            for(int i = 0; i < row1; i++)
                for(int j = 0; j < col1; j++)
                    
                            {
                                mul1 = array1[i,i] * array2[i,i];
                                mul2 = array1[i,j] * array2[j,i];
                                mul3 = array1[i,i] * array2[i,j];
                                mul4 = array1[i,j] * array2[j,j];
                                sum1 = mul1 + mul2;
                                sum2 = mul3 + mul4; 
                                
                            }   
                              
                              



        }



}



int[,] newArray1 = CreateRandom2dArray();
int[,] newArray2 = CreateRandom2dArray();
Show2dArray(newArray1);
Show2dArray(newArray2);
//Задача №4 - Попробовать через рекурсию, но необязательно. Как выводить трёхмерный массив - 

//Задача №5 - Самая сложная! Решить в общем виде массив m x n