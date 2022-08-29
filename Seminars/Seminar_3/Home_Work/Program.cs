// Задача № 1 (решение 1) Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
bool Polindron(int num) //Метод для проверки числа на полиндром
{
    int ed;
    int dec;
    int dec1;
    int south;
    int south1;
    int decSouth;
    ed = num % 10;
    dec = num % 100;
    dec1 = dec / 10;
    south = num / 1000;
    south1 = south % 10;
    decSouth = num / 10000;
    if (south1 == dec1 && decSouth == ed) return true;
    else return false;
}
Console.WriteLine("Программа для проверки пятизначного числа на полиндром");
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine()); 
String otvet = Convert.ToString(Polindron(number));
if(otvet == "False") Console.WriteLine("Нет, число не полиндром");
else Console.WriteLine("Да, число является полиндромом");
*/
//Задача № 1 (решение 2) Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
void Polindron(long number)
{
   long rev = 0;
   long result = 0;
   long current = number;
   while ( current > 0)
   {
    rev = current % 10;
    result = result * 10 + rev;
    current = current / 10;
    }
   Console.WriteLine(result);
   if (result == number) Console.WriteLine($"Число {number} - полиндом!");
   else Console.Write($"Число {number} -  не полиндом!");    
}
Console.WriteLine("Программа для проверки числа на полиндром");
Console.Write("Введите число: ");
long number = Convert.ToInt64(Console.ReadLine()); 
Polindron(number);
*/
//Задача № 2 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
double FindDist3D(double xA, double yA, double zA, double xB, double yB, double zB)
{
    double squadX = Math.Pow(xB - xA, 2); // Возводим в квадрат разницу между координатами точки B и А
    double squadY = Math.Pow(yB - yA, 2); 
    double squadZ = Math.Pow(zB - zA, 2);
    double dist3D = Math.Sqrt(squadX + squadY + squadZ); //Метод получения растояния от точки A и Б
    return dist3D;
}
Console.Write("Enter the coordinate X the point A: ");
double xA = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter the coordinate Y the point A: ");
double yA = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter the coordinate Z the point A: ");
double zA = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter the coordinate X the point B: ");
double xB = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter the coordinate Y the point B: ");
double yB = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter the coordinate Z the point B: ");
double zB = Convert.ToDouble(Console.ReadLine());
double dist = FindDist3D(xA, yA, zA, xB, yB, zB);
Console.WriteLine("Distance between A and B in 3D space: " + dist);
*/
//Задача № 3 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*
void TableCubeNumbers(int number)
{
    int counter = 1;
    while(counter <= number)
    {
        double numberCube = Math.Pow(counter, 3);
        Console.Write(numberCube + " ");
        counter++;
    }
}
Console.WriteLine("Таблица кубических чисел от 1 до N");
Console.Write("Введите число N: ");
int number = Convert.ToInt32(Console.ReadLine());
TableCubeNumbers(number);
*/