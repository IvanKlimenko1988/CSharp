//Задача №1 Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
void PrintSecondNumber(int number)
{
    int hund = number % 100;
    int secondNum = hund / 10;
    Console.WriteLine($"Вторая цифра этого числа: {secondNum}");
}

Console.Write("Введите трёхзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

PrintSecondNumber(num);
*/
//Задача №2 Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
void FindThirdNumber(int number)
{
    int dec;
    int hund;
    int oneHund;
    int tenHundred;
    if(number > 99)
    {
        if(number <= 100_000)
        {
            if(number >= 10_000)
            {
                oneHund = number / 100;
                dec = oneHund % 10;
                Console.WriteLine($"Третья цифра цисла {number} : {dec}");
            }
                if(number < 10_000)
                {
                    if(number >= 1000)
                    {
                        tenHundred = number % 100;
                        dec = tenHundred / 10;
                        Console.WriteLine($"Третья цифра цисла {number} : {dec}");
                    }
                }
                if(number < 1000)
                {
                    hund = number % 10;
                    Console.WriteLine($"Третья цифра цисла {number} : {hund}");
                }
        }   
    }
    else  Console.WriteLine("Третьей цифры нет");
}
Console.WriteLine("Программа для вывода третьей цифры заданного числа");
Console.Write("Введите положительное число до 100_000: ");
int num = Convert.ToInt32(Console.ReadLine());
FindThirdNumber(num);
*/
//Задача №3 Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

void PrintDayOfWeek(int number)
{
     if(number >=1)
     {
        if(number <= 5)
        {
            Console.WriteLine("Нет");
        }
     }
     if(number <= 7)
     {
        if(number >= 6)
        {
            Console.WriteLine("Да");   
        }   
    }   
}
Console.WriteLine("Является ли число, обозначающее день недели, выходным?");
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
PrintDayOfWeek(number);
