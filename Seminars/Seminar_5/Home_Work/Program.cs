//Задача №1 - Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int [] newArray = new int[size];
    
    for (int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue + 1);
    return newArray;
}

void ShowArray(int [] array)
{
    for( int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();    
}

int FindEvenNumbers(int[]array)
{
    int count = 0;

    for(int i = 0; i < array.Length; i++)
        if(array[i] % 2 == 0) count++;
    return count;
}

Console.WriteLine("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input min possitible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input max possitible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int [] myArray = CreateRandomArray(size, min, max);
ShowArray(myArray);
int countNumbers = FindEvenNumbers(myArray);
Console.WriteLine("The number of even numbers in the array: " + countNumbers);
*/

//Задача №2 - Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int [] newArray = new int[size];

    for (int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue + 1);
    return newArray;
}

void ShowArray(int [] array)
{
    for( int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();    
}

int FindSumOddPosition(int[] array)
{
    int sum = 0;

    for(int i = 1; i < array.Length; i = i + 2)
        sum+= array[i];
    return sum;
}

Console.WriteLine("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input min possitible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input max possitible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int [] myArray = CreateRandomArray(size, min, max);
ShowArray(myArray);
int sumNumbersArray = FindSumOddPosition(myArray);
Console.WriteLine("The sum of elements at odd positions in the array: " + sumNumbersArray);
*/

//Задача №3 - Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76  - позиция - индексы(0 чётная позиция)NextDouble() - генерирует от 0 до 1 //0,5 0,1 Next() + NextDouble 1 + 0,1


double[] CreateRandomArray(int size, int minValue, int maxValue)
{
    double [] newArray = new double[size];

    for (int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue + 1) + new Random().NextDouble(); //Запишем случайное вещественное число (1 + 0,1)
    return newArray;
}

void ShowArray(double[] array)
{
    for( int i = 0; i < array.Length; i++)
        Console.Write($"[{array[i]}] ");
    Console.WriteLine();    
}

double FindDifferenceMaxMinValue(double[] array) //Метод вычисления разницы между максимальным и минимальным элементами массива
{
    double minValue = array[0];
    double maxValue = array[0];

    for(int i = 0; i < array.Length; i++)
    {
        if(minValue > array[i]) minValue = array[i];
        if(maxValue < array[i]) maxValue = array[i];
    }
    double result = maxValue - minValue;
    return result;
}

Console.WriteLine("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input min possitible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input max possitible value: ");
int max = Convert.ToInt32(Console.ReadLine());

double [] myArray = CreateRandomArray(size, min, max);
ShowArray(myArray);

double diffMaxMin = FindDifferenceMaxMinValue(myArray);
Console.WriteLine("The difference between the maximum and minimum array elements: " + diffMaxMin);