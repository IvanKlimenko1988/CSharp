using System;
using static System.Console;

//Задача № 1 - Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""
/*
Clear();
Write("Введите число М: ");
int numberM = Convert.ToInt32(ReadLine());
Write("Введите число N: ");
int numberN = Convert.ToInt32(ReadLine());
WriteLine(PrintNumbers(numberM, numberN));

string PrintNumbers(int numM, int numN)
{
    if(numM == numN) return numM.ToString();
    return (numM + " " + PrintNumbers(numM + 1, numN));
}
*/
//Задча № 2 - Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
/*
Clear();
Write("Введите число М: ");
int numberM = Convert.ToInt32(ReadLine());
Write("Введите число N: ");
int numberN = Convert.ToInt32(ReadLine());
int result = GetSumNumbers(numberM, numberN);
Write(result);
int GetSumNumbers(int numberM, int numberN)
{
    int sum = numberM;
    if (numberM >= numberN) return sum;
    else
    {
        sum = GetSumNumbers(numberM + 1, numberN);
        sum += numberM;
        return sum;
    }
}
*/
//Задача № 3 - Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29

int FunctionOfAckerman(int m, int n)
{
    if (m == 0) return n + 1;
        else if (m != 0 && n == 0) return FunctionOfAckerman(m - 1, 1);
            else return FunctionOfAckerman(m - 1, FunctionOfAckerman(m, n - 1));
}

Write("Введите число М: ");
int numberM = Convert.ToInt32(ReadLine());
Write("Введите число N: ");
int numberN = Convert.ToInt32(ReadLine());
int resultFunction = FunctionOfAckerman(numberM, numberN);
Console.WriteLine($"Функция Аккермана А: ({numberM},{numberN}): {resultFunction}");

