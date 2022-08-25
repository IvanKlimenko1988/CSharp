// Задача № 1 Напишите программу, которая по заданным координатам точки, показывает в какой координатной плоскости она лежит.
/*
int FindQuarant(double x, double y) //Метод для поиска точки в координатной четверти
{
    if (x > 0 && y > 0) return 1; // Первая координатная четверть, где X - положильная координата и Y - положильная координата
    if (x < 0 && y > 0) return 2; // Вторая координатная четверть, где X - отрицательная координата и Y - положильная координата
    if (x < 0 && y < 0) return 3; // Третья координатная четверть, где X - отрицательная координата и Y - отрицательная координата
    if (x > 0 && y < 0) return 4; // Четвёртая координатная четверть, где X - положильная координата и Y - отрицательная координата
    return 0;                     // Возращаем 0, когда коорданата лежит на оси координат
}
Console.Write("Inpit X coordinate: ");
double xA = Convert.ToDouble(Console.ReadLine());
Console.Write("Inpit Y coordinate: ");
double yA = Convert.ToDouble(Console.ReadLine());

int quadrant = FindQuarant(xA, yA);
Console.WriteLine("Num of quad is " + quadrant);
*/
//Задача №2 Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
/*
void FindCoordinateXY(double x, double y) // Метод для поиска номера четверти по координатам точки
{
    if (x > 0 && y > 0) Console.WriteLine("The point in the first quarter"); // Точка в первой четверти
    if (x < 0 && y > 0) Console.WriteLine("The point in the second quarter"); // Точка во второй четверти
    if (x < 0 && y < 0) Console.WriteLine("The point in the third quarter"); // Точка в третьей четверти
    if (x > 0 && y < 0) Console.WriteLine("The point in the fourth quarter"); // Точка в четвертой четверти
    if (x == 0 || y == 0) Console.WriteLine("The point on the coordinate axis"); // Точка лежит на оси координат
}
Console.WriteLine("Enter the coordinate X:");
double xA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter the coordinate Y:");
double yA = Convert.ToDouble(Console.ReadLine());
FindCoordinateXY(xA, yA);
*/
//Задача №3 Напишите программу, которая принимает на вход число (n) и выдаёт квадраты чисел от 1 до n.
/*
void SquareNumbers(int number) // Метод для вывода квадратов чисел от 1 до n
{
    int counter = 1;
    int square;
    while(counter <= number)
    {
        square = counter * counter;
        counter++;
        Console.Write(square + " ");
    }
}
Console.WriteLine("Enter the number");
int number = Convert.ToInt32(Console.ReadLine());
SquareNumbers(number);
*/
//Задача №4 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве. Math.Sqrt()
/*
double FindDistance(double xA, double yA, double xB, double yB) // Метод для нахождения расстояния между двумя точками, теорема Пифагора (Корень квадратный из суммы квадратов катетов)
{
    double dist = Math.Sqrt((xB - xA) * (xB - xA) + (yB - yA) * (yB - yA)); // Метод Math.Sqrt() - возвращает корень квадратный выражения или числа
    return dist;
}
Console.WriteLine("Enter the coordinate X the point A:");
double xA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter the coordinate Y the point A:");
double yA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter the coordinate X the point B:");
double xB = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter the coordinate Y the point B:");
double yB = Convert.ToDouble(Console.ReadLine());

double dist = FindDistance(xA, yA, xB, yB);
Console.WriteLine("Distance between A and B: " + dist);
*/