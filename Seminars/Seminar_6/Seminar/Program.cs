// Задача №1 - Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int [] newArray = new int[size];

    for (int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue + 1);
    return newArray;
}

void ShowArray(int [] array)
{
    for( int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();    
}

Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possitible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possitible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int [] myArray = CreateRandomArray(size, min, max);
ShowArray(myArray);
 
int[] ReverseArray(int[] array)
{
    for (int i = 0, j = array.Length - 1; i < j; i++, j--)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }

    return array;
}

myArray = ReverseArray(myArray);
ShowArray(myArray);
*/
// Задача № 2 - Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Сумма любых двух сторон всегда больше другой стороны (a < b + c) (b < a + c) (c < b + a)  
/*
bool Triangle(int num1, int num2, int num3)
{
    if(num1 < num2 + num3 && num2 < num1 + num3 && num3 < num1 + num2) return true;
    else return false;
}
Console.Write("Введите первую сторону треугольника: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите вторую стророну треугольника: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третью сторону треугольника: ");
int number3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Существует ли треугольник со сторонами {number1} {number2} {number3} - {Triangle(number1, number2,number3)}");
*/
// Задача № 3 - Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: a и b. F(n) = F(n-1) + F(n-2)
/*
void Fibonachi(int numN, int numA, int numB)
{
    int temp = 0;
    Console.Write($"{numA} {numB} ");
    for(int i = 0; i < numN; i++)
    {
        temp = numA + numB;
        numA = numB;    
        numB = temp;
        Console.Write(numB + " ");
    }
}

Console.Write("Введите первые N чисел Фибоначи: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите первое число Фибоначи: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число Фибоначи: ");
int numberB = Convert.ToInt32(Console.ReadLine());

Fibonachi(number, numberA, numberB);
*/
// Задача № 4 - Напишите программу, которая будет преобразовывать десятичное число в двоичное.

string Binary(int num)
{
    string result = string.Empty;
    while(num > 0)
    {
        result = num % 2 + result;
        num = num / 2;
    }
    
    return result;
}
Console.Write(Binary(5));