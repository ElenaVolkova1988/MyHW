/*// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.0, 7, 8, -2, -2 -> 2;1, -7, 567, 89, 223-> 3
int PositivNumbers(int m)
{   
    int count=0;
    for(int i=0; i<m; i++)
{
        Console.WriteLine($"Input {i+1} element: ");
        int num=Convert.ToInt32(Console.ReadLine());
        if(num>0) count++;
}
    return count;
}
Console.WriteLine("Input a number of elements: ");
int m= Convert.ToInt32(Console.ReadLine());
int res = PositivNumbers(m);
Console.WriteLine($"Positiv numbers is {res}");*/

//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
    void Point(double b1, double b2,double k1,double k2)
{   
    double x =(-b2+b1)/(-k1+k2);
    double y=k2*x+b2;
    Console.WriteLine($"The lines will intersect at pointsy x :{x}, y: {y}");

    if(k1*b2==k2*b1) Console.WriteLine("Straight parallel");
}
    Console.WriteLine("Input coordinate b1 : ");
    double b1=Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Input coordinate k1 : ");
    double k1=Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Input coordinate b2 : ");
    double b2=Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Input coordinate k2 : ");
    double k2=Convert.ToDouble(Console.ReadLine());
    Point(b1,b2,k1,k2);
    Console.WriteLine();

 // k1*x+b1=k2*x+b2
 // k1*x-k2*x=-b1+b2
 // x(k1-k2)=-b1+b2
 // x=-b1+b2/-k1+k2