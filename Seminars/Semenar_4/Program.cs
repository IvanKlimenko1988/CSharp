//Задача № 1 - Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

/*
int FindSum(int num)
{
    int sum = 0;

    for (int current = 1; current <= num; current++)
        sum+= current;

    return sum;
}

Console.Write("Imput positive integer number: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Sum of numbers from 1 to {a} is {FindSum(a)}");
*/

//Задача № 2 - Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

/*
int SizeNumber(int num)         //Метод для поиска количесва чисел в числе
{
    int size = 0;
    while (num > 0 || num < 0)  //В условии цикла могут быть как положительные, так и отрицательные числа
    {
        num = num / 10;         //Входящее число становиться на одно число числа меньше с каждым циклом
        size++;                 //Счётчик цифр числа
    }
    return size;
}

Console.Write("Imput integer number: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Size of number {number} is {SizeNumber(number)}");
*/

//Задача № 3 - Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

/*
int FindFactorial(int num) //Метод возврата произведения чисел от 1 до N
{
    int current = 1;       //Счётчик
    int factorial = 1;        
    while(current <= num)
    {
        factorial = factorial * current;
        current++;
    }
    return factorial;
}

Console.Write("Imput integer number: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Произведение чисел от 1 до {number} равно {FindFactorial(number)}");
*/

//Задача № 4 - Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.

int[] CreateNewArray(int size)
{
    int[] array = new int[size];
    return array;
}

void FillArray(int[] array, int minValue, int maxValue)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    } 
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
int [] randomNewArray = CreateNewArray(8);
FillArray(randomNewArray, 0, 1);
ShowArray(randomNewArray);
//ДЗ 25 задачу реальзовать через цикл

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];

    for(int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue + 1);

    return newArray;
}

ShowArray(CreateRandomArray(25,0,9));