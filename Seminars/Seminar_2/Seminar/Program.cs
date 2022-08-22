//Задача№1: Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
/*
int FindBiggerDigit(int number)
{
    int max;
    int ed = number % 10;
    int dec = number / 10;
    
    if (ed > dec) max = ed;
    else max = dec;

    return max;
}

int randNumber = new Random().Next(0, 100);
int biggerDigit = FindBiggerDigit(randNumber);

Console.WriteLine($"Bigger digit for {randNumber} is {biggerDigit}");
*/
//Задача№2: Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
/*
int DelSecondNumber(int number)
{
    int hund = number / 100;
    int ed = number % 10;
    int result = hund * 10 + ed;
    return result;
}

int randomNumber = new Random().Next(100, 1000);
int findNumber = DelSecondNumber(randomNumber);
Console.WriteLine($"В случайном трёхзначном числе {randomNumber} удалили вторую цифру и получили {findNumber}");
*/

//Задача№3: Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если второе число не кратно числу первому, то программа выводит остаток от деления.

void PrintMultiplicity(int number1, int number2)
{
    int result = number2 % number1;
    if (result == 0)
    Console.WriteLine($"Второе число {number2} кратно первому числу {number1}");
    else
    Console.WriteLine($"Второе {number2} число не кратно первому {number1}! Остаток от деления {result}");
}
Console.WriteLine("Введите первое число:");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число:");
int secondNumber = Convert.ToInt32(Console.ReadLine());

PrintMultiplicity(firstNumber, secondNumber);
