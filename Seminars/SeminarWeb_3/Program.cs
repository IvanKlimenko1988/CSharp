
using System;
using static System.Console;

//Task 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
/*
Clear();
Write("Введите пятизначное число: ");
int number = Convert.ToInt32(ReadLine());
long rev = 0;
long result = 0;
long current = number;
while (current > 0)
{
    rev = current % 10;
    result = result * 10 + rev;
    current = current / 10;
}
if (result == number) WriteLine($"Число {number} - полиндом!");
else Write($"Число {number} -  не полиндом!");
*/
//Task 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
/*
Clear();
Write("Введите координату точки А X: ");
int x1 = Convert.ToInt32(ReadLine());
Write("Введите координату точки B X: ");
int x2 = Convert.ToInt32(ReadLine());
Write("Введите координату точки A Y: ");
int y1 = Convert.ToInt32(ReadLine());
Write("Введите координату точки B Y: ");
int y2 = Convert.ToInt32(ReadLine());
Write("Введите координату точки A Z: ");
int z1 = Convert.ToInt32(ReadLine());
Write("Введите координату точки B Z: ");
int z2 = Convert.ToInt32(ReadLine());

double length = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2));
Write($"Длина между точками А и Б в 3D пространстве = {length:f2}");
*/
//Task 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 5 -> 1, 8, 27, 64, 125
// 3 -> 1, 8, 27

Clear();
Write("Введите число N: ");
int number = Convert.ToInt32(ReadLine());
Write($"Таблица кубов числа {number} -> ");
for (int i = 1; i <= number; i++)
{
    Write((i * i * i) + " ");
}