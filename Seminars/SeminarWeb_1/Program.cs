
//Task 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
/*
Console.Clear();
Console.Write("Введите первое число: ");
int firstNumber = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int secondNumber = int.Parse(Console.ReadLine());
if(firstNumber > secondNumber) Console.WriteLine("Max = " + firstNumber);
else Console.WriteLine("Max = " + secondNumber);
*/
//Task 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
/*
Console.Clear();
Console.Write("Введите первое число: ");
int firstNumber = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int secondNumber = int.Parse(Console.ReadLine());
Console.Write("Введите третье число: ");
int thirdNumber = int.Parse(Console.ReadLine());

int max = 0;
if (firstNumber > secondNumber) max = firstNumber;
else max = secondNumber;
if (secondNumber < thirdNumber) max = thirdNumber;
if (firstNumber > thirdNumber) max = firstNumber;
Console.Write("Max = " + max);
*/
//Task 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет
/*
Console.Clear();
Console.WriteLine("Проверим является ли число чётным?");
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
bool answer = false;
if(number % 2 == 0)
{
    answer = true;
    Console.Write(answer);
}
else Console.Write(answer);
*/
//Task 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Clear();
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if(number % 2 == 0)
{
    for(int i = 2; i <= number; i = i + 2)
    Console.Write(i + " ");

}
if(number % 2 != 0)
{
    for(int i = 2; i < number; i = i + 2)
    Console.Write(i + " ");
}