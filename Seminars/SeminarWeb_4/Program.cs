using System;
using static System.Console;

//Task 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
/*
Clear();
double ExponetionNumber (int numA, int numB)
{
    double pow8 = Math.Pow(numA, numB);
    return pow8;
}
Write("Введите число А: ");
int numberA = Convert.ToInt32(ReadLine());
Write("Введите число B: ");
int numberB = Convert.ToInt32(ReadLine());    

double result = ExponetionNumber(numberA, numberB);
Write($"{numberA}, {numberB} -> {result}");
*/
//Task 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
/*
int FindSumDigits(int num)
{
    int sum = 0;
    int current = num;
    while(current > 0)
    {
        sum += current % 10;
        current/=10;
    }
    return sum;
}
Write("Введите число: ");
int number = Convert.ToInt32(ReadLine());
int sumDigit = FindSumDigits(number);
Write($"Сумма цифр числа {number} = {sumDigit}");
*/
//Task 29:  Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1 , 33]

Clear();
int [] CreateRandomArray()
{
    Write("Введите размер массива: ");
    int size = Convert.ToInt32(ReadLine());
    int[] array = new int [size];
    for(int i = 0; i < size; i++)
    {
        Write($"Введите {i + 1} элемент массива: ");
        array[i] = Convert.ToInt32(ReadLine());
    }
    return array;
}

void PrintArray(int[]array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Write(array[i] + " ");
    }
}

int[] newArray = CreateRandomArray();
PrintArray(newArray);