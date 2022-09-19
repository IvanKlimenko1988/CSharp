//Задача №1 - Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.(Рекурсия)

// void ShowNums(int n)
// {
//     if(n > 1) ShowNums(n - 1);

//     Console.Write(n + " ");

// }
// ShowNums(5);

// //Задача №2 - Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр. (Рекурсия)

// int SumOfDigits(int n)
// {
//     if(n > 0) return SumOfDigits(n / 10) + n % 10;
//     else return 0;
// }   


// Console.Write(SumOfDigits(5464)); 

//Задача №3 - Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

void ShowNums(int m, int n)
{   
    
    if(n > m)
    {
        if(n > m) ShowNums(m, n - 1);
        Console.Write(n + " ");
    }
    else
    {
        if(m > n) ShowNums(m, n + 1);
        Console.Write(n + " ");
    }
   
}
ShowNums(1, 9);

//Задача №4 - Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.

// int PowValue(int a, int b)
// {
//     if(b > 1) return PowValue(a, b -1)*a;
//     else return a;
// }
// Console.WriteLine(PowValue(2,3));