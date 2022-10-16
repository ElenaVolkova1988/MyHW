/*// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.[345, 897, 568, 234] -> 2

int [] CreateArray(int size) 
{
    int [] newarray =new int [size];

    for( int i=0; i<size; i++)
    {
              newarray[i]=new Random().Next(100,1000);
    }
    return newarray;
}
 void ShowArray (int []array) 
 {
    for( int i=0; i< array.Length; i++)
    Console.Write(array[i]+ " ");

    Console.WriteLine();
 }

 int EvenNumbers (int[] num)
 {
    int count =0;
    for (int i = 0; i < num.Length; i++)
{
         if(num [i] %2==0)
        count++;
}
    return count;
 }
Console.Write ("Input a number of elements: ");
int size =Convert.ToInt32(Console.ReadLine());
int [] myArray = CreateArray(size);
ShowArray(myArray);
int even = EvenNumbers(myArray);
EvenNumbers(myArray);
Console.WriteLine("Number of even numbers " + even);*/

/*//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.[3, 7, 23, 12] -> 19;[3 7 22 2 78] -> 76
int [] CreateArray(int size) 
{
    int [] newarray =new int [size];

    for( int i=0; i<size; i++)
    {
              newarray[i]=new Random().Next(100,1000);
    }
    return newarray;
}
 void ShowArray (int []array) 
 {
    for( int i=0; i< array.Length; i++)
    Console.Write(array[i]+ " ");

    Console.WriteLine();
 }
 int SumOddNumbers(int[]num)
 {
     int sum=0;
     for(int i=0; i<num.Length; i++)
{
      if(num [i] %2==1)
        sum=sum+num[i];
}
     return sum;
}

Console.Write ("Input a number of elements: ");
int size =Convert.ToInt32(Console.ReadLine());
int [] myArray = CreateArray(size);
ShowArray(myArray);
int sum=SumOddNumbers(myArray);
SumOddNumbers(myArray);
Console.WriteLine($"Sum odd numbers is " + sum);*/

/*//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.[3 7 22 2 78] -> 76
double[] CreateArray(int size) 
{
   double [] newarray =new double [size];

    for( int i=0; i<size; i++)
    {
         Console.WriteLine($"Input {i+1} number: ");
            newarray[i]=Convert.ToDouble(Console.ReadLine());
    }
    return newarray;
}
 void ShowArray (double []array) 
 {
    for( int i=0; i< array.Length; i++)
    Console.Write(array[i]+ " ");

    Console.WriteLine();
 }

 double Difference (double [] num)
{

   double diff=0;
   double min=num[0];
   double max=num[0];
   for(int i=0; i<num.Length; i++)
{
      if( num[i]<min)
{
         min=num[i];
}
      if (num[i]>max)
{
         max=num[i];
}
   diff=max-min;
 }
 return diff;
 }

Console.Write ("Input a number of elements: ");
int size =Convert.ToInt32(Console.ReadLine());
double [] myArray = CreateArray(size);
ShowArray(myArray);
double result= Difference(myArray);
Difference(myArray);
Console.WriteLine($"The difference between max and min "+ result);*/

// Доп.Найти произведение пар чисел в одномерном массиве.Парой считается первый элемент и последнииб второй и предпоследний и тд. Результат записать в новом массиве. [1 2 3 4 5]->5 8 3; [6 7 3 6 ]->36 21
int[] CreateArray(int size) 
{
   int [] newarray =new int [size];

    for( int i=0; i<size; i++)
    {
         Console.WriteLine($"Input {i+1} number: ");
            newarray[i]=Convert.ToInt32(Console.ReadLine());
    }
    return newarray;
}
void ShowArray (int []array) 
 {
    for( int i=0; i< array.Length; i++)
    Console.Write(array[i]+ " ");

    Console.WriteLine();
 }


int ProductNumber (int [] num)
{
   int product =0;
   int first= num[0];
   int last=num[num.Length-1];
   for(int i=0; i<num.Length/2; i++)
{
     product=first*last;
     
}
   return product;
}
 Console.Write ("Input a number of elements: ");
int size =Convert.ToInt32(Console.ReadLine());
int [] myArray = CreateArray(size);
ShowArray(myArray);
int result=ProductNumber(myArray);
ProductNumber(myArray);
Console.Write(result);