//Задача № 1 Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.

/*
int[] CreateRandomArray(int size, int minValue, int maxValue) //Метод для создания массива
{
    int [] newArray = new int[size];

    for (int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue + 1);

    return newArray;
}

void ShowArray(int [] array)                                   //Метод для вывода на экран массива
{
    for( int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine();
}

int FindPositivSum(int[] array)                                //Метод для поиска суммы положительных элементов
{
    int sum = 0;

    for (int i = 0; i < array.Length; i++)
        if(array[i] > 0) sum+= array[i]; // sum = sum + array[i];
    
    return sum;
}

int FindNegativeSum(int[] array)                               //Метод для поиска суммы отрицательных элементов
{
    int sum = 0;

    for (int i = 0; i < array.Length; i++)
        if(array[i] < 0) sum+= array[i]; // sum = sum + array[i];
    
    return sum;
}

Console.WriteLine("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input min possitible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input max possitible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, min, max);
ShowArray(myArray);

int positiveSum = FindPositivSum(myArray);
int negativeSum = FindNegativeSum(myArray);

Console.WriteLine($"Sum of positive elements is {positiveSum} \nSum of negative elements is {negativeSum}");
*/

//Задача № 2 Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.

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

int[] Swap(int[] array)                                         //Метод для замены положительный элементов на соответствующие отрицательные, и наоборот
{
    for (int i = 0; i < array.Length; i++)
        if (array[i] > 0 || array[i] < 0) array[i] = array[i] * (-1);
            
    return array; 
}

Console.WriteLine("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input min possitible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input max possitible value: ");
int max = Convert.ToInt32(Console.ReadLine());
int [] myArray = CreateRandomArray(size, min, max);
ShowArray(myArray);
int [] newArray = Swap(myArray);
ShowArray(newArray);
*/

//Задача № 3 Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

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

bool FindDigit(int[] array, int num)                           //Метод для поиска числа в массие
{
    for(int i = 0; i < array.Length; i++)
        {
            if(array[i] == num)
            return true;
        }
        return false;
}

Console.WriteLine("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input min possitible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input max possitible value: ");
int max = Convert.ToInt32(Console.ReadLine());
int [] myArray = CreateRandomArray(size, min, max);
ShowArray(myArray);
Console.WriteLine("Input find digit of array: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Is the value present in the array: " + FindDigit(myArray, number));
*/
        
//Задача № 4 Задайте одномерный массив из 12 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

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

int FindElementsArray(int[] array) //Метод для поиска количества элементов массмва, значения которых лежат в отрезке от 10 до 99
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
        if(array[i] >= 10 && array[i] < 100) count++;
    
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

int countDigit = FindElementsArray(myArray);
Console.WriteLine("The number of array elements is from 10 to 99: " + countDigit);
*/

//Задача № 5 Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// 1 2 3 4 5 -> 5 8 3
// 1 2 3 4 -> 4 6

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

int[] ProductNumbersArray(int[] array) //Метод для произведения пар чисел в массиве
{
    if(array.Length % 2 == 0) //Проверка массива на чётное количество элементов
    {
        int[] resultArray = new int[array.Length/2]; // Создаём новый массив, размер которого в 2 раза меньше входящего
        int count = 1;                               // Переменная, которая будет вычитаться на каждой итерации цикла
        for(int i = 0; i < resultArray.Length; i++)  
            {
                
                resultArray[i] = array[i] * array[array.Length - count]; //Произведение первого элемента массива на последний элемент, входящего массива
                count++;
            }
        return resultArray;    
    }
    else
    {
        int[] resultArray = new int[array.Length/2 + 1];               //Если массив с нечётным количесвом элементов, то тот элемент который остался без пары
        int count = 1;                                                 //в произведении не участвует и просто записывается в новый массив
        for(int i = 0; i < resultArray.Length; i++)
            {
                
                resultArray[i] = array[i] * array[array.Length - count];
                count++;
            }
        resultArray[resultArray.Length - 1] = array[array.Length/2];   //тут идёт запись элемента без пары в новый массив
        return resultArray;
    }
}

Console.WriteLine("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input min possitible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input max possitible value: ");
int max = Convert.ToInt32(Console.ReadLine());
int [] myArray = CreateRandomArray(size, min, max);
ShowArray(myArray);
int [] resultArray = ProductNumbersArray(myArray);
ShowArray(resultArray);



