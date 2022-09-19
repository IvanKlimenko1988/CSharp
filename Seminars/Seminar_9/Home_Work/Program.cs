
//Задача №1 - Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
/*
int FindSum(int m, int n)
{
    int sum = 0;
    if (n >= m)
    {
        if (n >= m)
            sum = FindSum(m + 1, n);
        return sum += m;
    }
    return sum;
}

Console.Write("Imput of number M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Imput of number N: ");
int numberN = Convert.ToInt32(Console.ReadLine());
int sum = FindSum(numberM, numberN);
Console.WriteLine("The sum of the numbers from M to N: " + sum);
*/
//Задача №3 - Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int FunctionOfAckerman(int m, int n)
{
    if (m == 0) return n + 1;
        else if (m != 0 && n == 0) return FunctionOfAckerman(m - 1, 1);
            else return FunctionOfAckerman(m - 1, FunctionOfAckerman(m, n - 1));
}

Console.Write("Imput of number M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Imput of number N: ");
int numberN = Convert.ToInt32(Console.ReadLine());
int resultFunction = FunctionOfAckerman(numberM, numberN);
Console.WriteLine($"The value of the Ackerman function A({numberM},{numberN}): {resultFunction}");

