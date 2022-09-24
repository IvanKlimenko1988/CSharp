using System;
using static System.Console;
//Task 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
/* Вариант 1
void FindSumPositiveNumbers()
{
    WriteLine("Подсчёт введёных положительных чисел");
    int i = 0;
    int count = 0;
    while (i == 0)
    {
        Write("Введите число: ");
        int number = Convert.ToInt32(ReadLine());
        if (number > 0) count++;
        WriteLine("Продолжить подчёт?");
        WriteLine("Введите да или нет");
        string otvet = ReadLine();
        if (otvet == "нет") break;
    }
    Write("Количество положительных чисел = " + count);
    
}
Clear();
FindSumPositiveNumbers();
*/
//Вариант 2

int GetSumPositiveNumbert(String arrayString)
{
    string[] nums = arrayString.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] result = new int[nums.Length];
    int sum = 0;
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = int.Parse(nums[i]);
        if (result[i] > 0) sum++;
    }
    return sum;
}
Clear();
Write("Введите числа через пробел:");
int sumPositiveNum = GetSumPositiveNumbert(ReadLine());
Write("Количество положительных чисел = " + sumPositiveNum);

//Task 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)

// void PrintCrossPoint(double ratioA1, double ratioA2,   //Метод для вывода точки пересечения двух прямых.
//                      double ratioB1, double ratioB2)    
// {
//     double x, y = 0;

//     x = (ratioB1 - ratioA1) 
//       / (ratioA2 - ratioB2);
//     y = ratioA2 * x + ratioA1;
//     Write($"Point of cross ({x}; {y})");
// }
// WriteLine("Find the intersection point if two equations are given: ");
// WriteLine("y = k1 * x + b1");
// WriteLine("y = k2 * x + b2");

// Write("Imput ratio b1: ");
// double b1 = Convert.ToDouble(ReadLine());
// Write("Imput ratio k1: ");
// double k1 = Convert.ToDouble(ReadLine());
// Write("Imput ratio b2: ");
// double b2 = Convert.ToDouble(ReadLine());
// Write("Imput ratio k2: ");
// double k2 = Convert.ToDouble(ReadLine());

// PrintCrossPoint(b1, k1, b2, k2);

