//Задача №1 Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

/*
Console.WriteLine("Найти какое из двух чисел больше, а какое меньше ");
Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2) Console.WriteLine($"Первое число {number1} больше чем второе число {number2}");
else Console.WriteLine($"Второе число {number2} больше чем первое число {number1}");
*/

//Задача №2 Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

/*
Console.WriteLine("Найти максимальное число из трёх");
Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");
int number3 = Convert.ToInt32(Console.ReadLine());

int max = number1;

if (number2 > max) max = number2;
if (number3 > max) max = number3;

Console.Write("Максимальное из трёх чисел: " + max);
*/

//Задача №3 Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

/*
Console.WriteLine("Проверим является ли число чётным ");
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0) Console.WriteLine($"Число {number} является чётным");
else Console.WriteLine($"Число {number} является нечётным");
*/

//Задача №4 Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.


Console.WriteLine("Вывести все чётные числа от 1 до N: ");
Console.Write("Введите число N: ");
int number = Convert.ToInt32(Console.ReadLine());

int current = 1;
Console.Write($"Диапазон чётных чисел от 1 до {number}: ");
while (current <= number)
{
    if(current % 2 == 0) Console.Write(current + " ");  
current++;
}
