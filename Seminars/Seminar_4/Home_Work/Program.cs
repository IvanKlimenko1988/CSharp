//Задача №1 - Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
int RaiseToDegree(int numberA, int numberB) //Метод, который возводит в степерь число А в степень Б 
{
    int degree = 1;
    for(int i = 1; i <= numberB; i++)
    {
        degree = degree * numberA;
    }
    return degree;
}

Console.WriteLine("Программа для возведения числа А в степень Б");
Console.Write("Введите число А: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int numB = Convert.ToInt32(Console.ReadLine());

int numDegree = RaiseToDegree(numA, numB);
Console.WriteLine($"Число {numA} в степени {numB} = " +  numDegree);
*/
//Задача №2 - Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
int sumDigit(int num) //Метод для возврата суммы цифр в числе
    {
        int ed = 0;
        int sum = 0;
        int current = num;
        while (current > 0 || current < 0)
        {
            ed = current % 10;
            sum = sum + ed;
            current = current / 10;
        }
        if (sum < 0) sum = sum * (-1);
    return sum;
    }

Console.WriteLine("Программа для вывода суммы цифр в числе");
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int sumDigitNumber = sumDigit(number);
Console.WriteLine($"Сумма цифр числа {number} = {sumDigitNumber}");
*/
// //Задача №3 - Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] CreateConsoleArray()  //Метод для создания массива через консоль
    {
        Console.Write("Создадим массив. Укажите размер массива: ");
        int sizeNumber = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Заполните ячейки массива значениями.");
        int[] newArray = new int[sizeNumber];
        for (int i = 0; i < newArray.Length; i++)
        {
            Console.WriteLine($"Введите {i+1} элемент массива: ");
            newArray[i] = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
        }   
    return newArray;
    }

void PrintArray(int[] array) //Метод для печати массива в консоль
    {
        Console.Write("Массив: ");
        for(int i = 0; i < array.Length; i++)
        {
            Console.Write("["+array[i]+"]" + " ");
        }
        Console.WriteLine();
    }

int[] myArray = CreateConsoleArray();

PrintArray(myArray);
