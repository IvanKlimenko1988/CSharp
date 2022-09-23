
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
/*
Clear();
Write("Введите число: от -1000000 до 1000000: ");
int number = int.Parse(ReadLine());
if(number > -100 && number < 100) WriteLine($"{number} -> третьей цифры нет");
int hud = number / 10;
if (number >= 100 && number < 1000) Write($"{number} -> {number % 10}");
if (number >= 1000 && number < 10000) Write($"{number} -> {hud % 10}");
if (number >= 10000 && number < 100000) Write($"{number} -> {(hud / 10) % 10}");
if (number >= 100000 && number < 1000000) Write($"{number} -> {(hud / 100) % 10}");
if (number >= -1000 && number <= -100) Write($"{number} -> {number % 10 * (-1)}");
if (number >= -10000 && number < -1000) Write($"{number} -> {hud % 10 * (-1)}");
if (number >= -100000 && number < -10000) Write($"{number} -> {(hud / 10) % 10 * (-1)}");
if (number >= -1000000 && number < -100000) Write($"{number} -> {(hud / 100) % 10 * (-1)}");
*/
//Task 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Clear();
Write("Введите цифру дня недели: ");
int dayOfWeek = int.Parse(ReadLine());
if(dayOfWeek == 6 || dayOfWeek == 7) Write($"{dayOfWeek} -> Да");
if(dayOfWeek > 0 && dayOfWeek < 6) Write($"{dayOfWeek} -> Нет");
if(dayOfWeek <= 0 || dayOfWeek > 7) Write("Введен неверный день недели");