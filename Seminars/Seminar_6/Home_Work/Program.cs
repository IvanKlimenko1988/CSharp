//Задача №1 - Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*
void CountInPosNum() //(Вариант 1: Метод для подсчёта положительных чисел, с бесконечным вводом)
{
    int quantity = 0;
    for (int i = 1; ; i++)
    {
        Console.Write("Imput number: ");
        int imputNum = Convert.ToInt32(Console.ReadLine());
        if(imputNum > 0) quantity++;
        Console.WriteLine("The number of positive numbers entered: " + quantity);
    }
}
CountInPosNum();
*/
/*
int CountInPosNum(int num) //(Вариант 2: Метод для подсчёта положительных чисел из определенно количества)
{
    int quantity = 0;
    for (int i = 1; i <= num; i++)
    {
        Console.Write($"Imput number {i}: ");
        int imputNum = Convert.ToInt32(Console.ReadLine());
        if(imputNum > 0) quantity++;
        Console.WriteLine("The number of positive numbers entered: " + quantity);
    }

    return quantity;
}
Console.Write("How many entered numbers do you want to check? - ");
int number = Convert.ToInt32(Console.ReadLine());
int result = CountInPosNum(number);
*/
//Задача №2 - Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// y = k1 * x + b1;
// y = k2 * x + b2;

// k1 * x + b1 == k2 * x + b2;
// x = (b2 - b1) / (k1 - k2);
// y = k1 * (b2 - b1) / (k1 - k2) + b1;

void PrintCrossPoint(double ratio_b1, double ratio_k1, 
                     double ratio_b2, double ratio_k2)
{
    double x = 0;
    double y = 0;
    if ((ratio_b1 * ratio_k2 - ratio_k1 * ratio_b2) == 0) Console.WriteLine("Straight lines are parallel!"); //Условие: пересекаются ли прямые
    else {
            x = (ratio_b2 - ratio_b1) / (ratio_k1 - ratio_k2);
            y = ratio_k1 * x + ratio_b1;
            Console.Write($"Point of cross ({x}; {y})");
         }
}
Console.WriteLine("Find the intersection point if two equations are given: ");
Console.WriteLine("y = k1 * x + b1");
Console.WriteLine("y = k2 * x + b2");

Console.Write("Imput b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Imput k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Imput b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Imput k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

PrintCrossPoint(b1, k1, b2, k2);
