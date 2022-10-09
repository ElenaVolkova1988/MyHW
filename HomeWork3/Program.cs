/*
// Задача 19.Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.14212 -> нет; 12821 -> да;23432 -> да

    string Palindrom (string number)
    {
         int len = number.Length;
         if(len==5)
         {
            if (number [0]== number[4]&& number[1]==number[3])
            {
                Console.WriteLine($"Count {number} is palindrom");
            }
            else
            {
                Console.WriteLine($"Count {number} is not palindrom");
            }
         }
            else
            {
                Console.WriteLine("ERROR");
            }
         
        return number;
    }
    Console.WriteLine("Input a number: ");
    string number = Convert.ToString(Console.ReadLine());
    Palindrom (number);
    */
   
/*
// Задача 21.Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве. A (3,6,8); B (2,1,-7), -> 15.84; A (7,-5, 0); B (1,-1,9) -> 11.53
    double Distanc ( double xa, double ya,double za, double xb, double yb, double zb)
    {
      return Math.Round((Math.Sqrt (Math.Pow((xb-xa),2)+ Math.Pow(( yb-ya),2)+ Math.Pow((zb-za),2))),2);
    }
    Console.Write("Input xa-coordinate: ");
    double xa = Convert.ToDouble(Console.ReadLine());        
    Console.Write("Input ya-coordinate: ");
    double ya = Convert.ToDouble(Console.ReadLine());  
    Console.Write("Input za-coordinate: ");
    double za = Convert.ToDouble(Console.ReadLine()); 
    Console.Write("Input xb-coordinate: ");
    double xb = Convert.ToDouble(Console.ReadLine()); 
    Console.Write("Input yb-coordinate: ");
    double yb = Convert.ToDouble(Console.ReadLine()); 
    Console.Write("Input zb-coordinate: ");
    double zb = Convert.ToDouble(Console.ReadLine()); 

   Console.WriteLine(Distanc(xa,ya,za,yb,xb,zb));
   */

/*
// Задача 23.Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N. 3 -> 1, 8, 27; 5 -> 1, 8, 27, 64, 125
void WriteQ(int n) 
{
    int count =1;
    while (count<=n)
    {
        Console.WriteLine(Math.Pow(count,3));
        count++;
    }
}
 Console.WriteLine("Input N number: ");
 int n =Convert.ToInt32(Console.ReadLine());
 WriteQ(n);
 */