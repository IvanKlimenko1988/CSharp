//Задача №1 -  Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
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

// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
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

        Console.WriteLine("Multiplication of two array:");

        for (int i = 0; i < row1; i++)
            {
                 for (int j = 0; j < col2; j++)
                Console.Write(mulArray[i, j] + " ");

                Console.WriteLine();
            }

            Console.WriteLine();
    }
    else Console.WriteLine("Multiplication of two array is possible if: columns Arr 1 == rows Arr 2!");    
}


int[,] newArray1 = CreateRandom2dArray();
int[,] newArray2 = CreateRandom2dArray();

MulArray(newArray1, newArray2);
*/

//Задача №4 - Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
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
//Задача №5 -Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07 Самая сложная! Решить в общем виде массив m x n
