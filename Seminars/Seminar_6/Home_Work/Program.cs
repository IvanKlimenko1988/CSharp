//Задача №1 - Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//Вариант 1:
/*
void CountInPosNum() // Метод для подсчёта положительных чисел, с бесконечным вводом.
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
//Вариант 2:
/*
int CountInPosNum(int num) // Метод для подсчёта положительных чисел из определенно количества.
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

//Задача №2 - Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями: 
//y = k1 * x + b1, 
//y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.

//Вариант 1:
/*
void PrintCrossPoint(double ratioA1, double ratioA2,   //Метод для вывода точки пересечения двух прямых.
                     double ratioB1, double ratioB2)    
{
    double x, y = 0;
    
    x = (ratioB1 - ratioA1) 
      / (ratioA2 - ratioB2);
    y = ratioA2 * x + ratioA1;
    Console.Write($"Point of cross ({x}; {y})");
}
Console.WriteLine("Find the intersection point if two equations are given: ");
Console.WriteLine("y = k1 * x + b1");
Console.WriteLine("y = k2 * x + b2");

Console.Write("Imput ratio b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Imput ratio k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Imput ratio b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Imput ratio k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

PrintCrossPoint(b1, k1, b2, k2);
*/
//Вариант 2:
/*
void GeneralSolutionOfLines(double a1, double b1,   //Общий метод решения задач с прямыми линиями.
                            double c1, double a2,   // a1, a2 - коэффициенты уравнения x
                            double b2, double c2)   // b1, b2 - коэффициенты уравнения y
{                                                   // c1, c2 - свободные члены
    double x, y = 0;
    
    if ((a1 * b2 - a2 * b1) == 0) 
        Console.WriteLine("Straight lines are parallel!"); //Прямые параллельны другу друг и не имеют точек пересечения.
    if (a1 * b2 == b1 * a2 && 
        a1 * c2 == a2 * c1 && 
        b1 * c2 == c1 * b2)
        Console.WriteLine("Straight lines match!");        //Прямые совподают и имеют бесконечное количество решений.
    else
    {
        x = (b1 * c2 - b2 * c1) 
          / (a1 * b2 - a2 * b1);
        y = (a2 * c1 - a1 * c2)
          / (a1 * b2 - a2 * b1);
        Console.Write($"Point of cross ({x}; {y})"); // Точки пересечения двух прямых.      
    }
}

Console.WriteLine("Find the intersection point if two equations are given: ");
Console.WriteLine("b1 * y = a1 * x + c1");
Console.WriteLine("b2 * y = a2 * x + c2");

Console.Write("Imput ratio a1: ");
double a1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Imput ratio b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Imput ratio c1: ");
double c1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Imput ratio a2: ");
double a2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Imput ratio b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Imput ratio c2: ");
double c2 = Convert.ToDouble(Console.ReadLine());

GeneralSolutionOfLines(a1, b1, c1, a2, b2, c2);
*/