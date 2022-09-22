using static System.Console;
using System;
 //Tasl 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
/*
Clear();
Write("Введите трёхзначное число: ");
int number = int.Parse(ReadLine());
int dec = (number / 10) % 10;
WriteLine($"Вторая цифра числа {number} -> {dec}");
*/
//Task 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
if(number < 100 || number > -100) WriteLine($"{number} -> третьей цифры нет");
while(number < 1000)
