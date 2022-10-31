// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами. m = 3, n = 4. 0,5 7 -2 -0,2; 1 -3,3 8 -9,9;8 7,8 -7,1 9


/*double [,] RealNumbers2dArray()//Генерация массива
{
    Console.Write("Input a number of rows: ");
    int rows= Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns= Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minValue= Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxValue= Convert.ToInt32(Console.ReadLine());

    double[,] array= new double [rows, columns];// выделение памяти под введенное пользователем кол-во строк и столбцов

    for(int i=0; i<rows;i++)
        for(int j=0; j<columns;j++)
            array[i,j] = new Random().Next(minValue,maxValue+1);
    return array;    
}

 void Show2dArray( double[,] array)
{
    for(int i=0; i<array.GetLength(0);i++)
    {
        for(int j=0; j<array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();    
    }
}

double[,] myArray=RealNumbers2dArray();
Show2dArray(myArray);*/

/*int [,] Create2dArray()//Генерация массива
{
   
    int[,] array= new int [3, 4];// выделение памяти под введенное пользователем кол-во строк и столбцов

    for(int i=0; i<3;i++)
        for(int j=0; j<4;j++)
            array[i,j] = new Random().Next(1,10);
    return array;    
}

 void Show2dArray( int[,] array)
{
    for(int i=0; i<array.GetLength(0);i++)
    {
        for(int j=0; j<array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();    
    }
}
//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:1 4 7 2;5 9 2 3;8 4 2 4;1 7 -> числа с такими индексами в массиве нет

int [,] FindElements2dArray( int [,] array)
{
    Console.WriteLine("Input a number rows: ");
    int numberRows=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a number columns: ");
    int numberColumns=Convert.ToInt32(Console.ReadLine());

    if (numberRows < array.GetLength(0)-1 && numberColumns < array.GetLength(1)-1)
     Console.WriteLine($"The number is: {array [numberRows, numberColumns]}");
    else
      Console.WriteLine("The element is missing");
    return array;
}

int[,] myArray=Create2dArray();
Show2dArray(myArray);
FindElements2dArray(myArray);*/

int [,] Create2dArray()//Генерация массива
{
   
    int[,] array= new int [3, 4];// выделение памяти под введенное пользователем кол-во строк и столбцов

    for(int i=0; i<3;i++)
        for(int j=0; j<4;j++)
            array[i,j] = new Random().Next(1,10);
    return array;    
}

 void Show2dArray( int[,] array)
{
    for(int i=0; i<array.GetLength(0);i++)
    {
        for(int j=0; j<array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();    
    }
}
//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.Например, задан массив: тотже самый выше Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void ShowArray (double []array) 
{
    for( int i=0; i< array.Length; i++)
    Console.Write(array[i]+ " ");

    Console.WriteLine();
}
double [] ArithmeticMean ( int[,] array)
{  
    double [] resArray=new double [array.GetLength(1)];
        for(int j=0; j<array.GetLength(1);j++)
{       int sum=0;
            for(int i=0; i<array.GetLength(0); i++)
{ 
                sum =sum+array [i,j];
                resArray[j]=sum/array.GetLength(0);       
} 
            sum=0;
    }
 return resArray;
}
int[,] myArray=Create2dArray();
Show2dArray(myArray);
double []resArray= ArithmeticMean(myArray);
Console.WriteLine();
ShowArray(resArray);



