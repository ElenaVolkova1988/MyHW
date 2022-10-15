// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.3, 5 -> 243 (3⁵);2, 4 -> 16
  /*                                                 // Без цикла

   double PowerNumber (double a , double b )
{
    return Math.Pow(a,b);    
}
   Console.WriteLine("Input first digit :  ");
   int a = Convert.ToInt32(Console.ReadLine());
   Console.WriteLine("Input second digit :  ");
   int b = Convert.ToInt32(Console.ReadLine());
   PowerNumber(a,b);
   Console.WriteLine($"Number {a} to the {b} power is {PowerNumber(a,b)}");*/
 

                                                     // Цикл while 
 /* 
   double PowerNumber (double a , double b)
{
   int i=0;
   double pow=1;
   while ( i<b)
{
         pow=pow*a; 
         i++; 
}
   return pow;
}
   Console.WriteLine("Input a number: ");
   double a=Convert.ToInt32(Console.ReadLine());
   Console.WriteLine("Input a number that elevates to a power: ");
   double b=Convert.ToInt32(Console.ReadLine());
   Console.WriteLine($"Number {a} to the {b} power is {PowerNumber(a,b)} ");*/
   


/*                                                    // Цикл for (думаю лучше через while)

   double PowerNumber (double a , double b)
{
   double pow=1;
   for(int i=0;i<b;i++)
      pow=pow*a;
   return pow;
}
   Console.WriteLine("Input a number: ");
   double a=Convert.ToInt32(Console.ReadLine());
   Console.WriteLine("Input a number that elevates to a power: ");
   double b=Convert.ToInt32(Console.ReadLine());
   double pow = PowerNumber(a,b);
   Console.WriteLine($"Number {a} to the {b} power is {pow}");*/

/*// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.452 -> 11;82 -> 10;9012 -> 12
   
   int SumDigit( int a)
   {
      int sum =0;
      if (a < 0)
   {
         a=a*-1;
   }
      while( a>0)
   {
           sum=sum+a%10;
           a=a/10;
   }
      return sum;
   }
   Console.WriteLine("Input a number: ");
   int num  = Convert.ToInt32(Console.ReadLine());
   int s = SumDigit(num);
   Console.WriteLine("Sum is " + s);*/

   //Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.m = 5 -> [1, 2, 5, 7, 19];m = 3 -> [6, 1, 33]

   int [] MArray ( int size)
{
   int [] array = new int[size];
      for(int i=0; i< size ; i++)
{
      Console.Write($"Input a {i+1} element of array: ");
      array [i]= Convert.ToInt32(Console.ReadLine());
}
         return array;
} 
   void ShowArray ( int [] array)
{
           for(int i=0; i<array.Length; i++)
             Console.Write(array[i]+ " ");

    Console.WriteLine();

}
Console.WriteLine("Input number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
int [] myarray=MArray(size);
ShowArray(myarray);
Console.WriteLine( myarray);
