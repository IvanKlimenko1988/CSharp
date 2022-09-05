// Задача №1 - Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)

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

// Задача № 2 - Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Сумма любых двух сторон всегда была больше другой стороны (a < b + c) (b < a + c) (c < b + a)  

// Задача № 3 - Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: a и b. F(n) = F(n-1) + F(n-2)

// Задача № 4 - Напишите программу, которая будет преобразовывать десятичное число в двоичное.