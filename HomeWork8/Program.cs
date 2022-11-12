/*// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
    int[,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows= Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns= Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minValue= Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxValue= Convert.ToInt32(Console.ReadLine());

    int[,] array=new int[rows, columns];// выделение памяти под введенное пользователем кол-во строк и столбцов

    for(int i=0; i<rows;i++)
        for(int j=0; j<columns;j++)
            array[i,j] = new Random().Next(minValue,maxValue+1);
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

 void  Order ( int[,] array )
{
    int [,] resArray= new int [array.GetLength(0),array.GetLength(1)];
    for( int i = 0; i < array.GetLength(0); i++)
    {   
        for( int j=0; j < array.GetLength(1); j++)
        {   
        for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                
                }
        }
}}}

int[,] myArray=CreateRandom2dArray();
Show2dArray(myArray);
Order(myArray);
Console.WriteLine();    
Show2dArray(myArray);*/

/*//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows= Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns= Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minValue= Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxValue= Convert.ToInt32(Console.ReadLine());

    int[,] array=new int[rows, columns];// выделение памяти под введенное пользователем кол-во строк и столбцов

    for(int i=0; i<rows;i++)
        for(int j=0; j<columns;j++)
            array[i,j] = new Random().Next(minValue,maxValue+1);
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

void SumOfElements (int[,] array)
{   
    int minRow = 0;
    int minSumRow = 0;
    int sumRow = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        minRow += array[0, i];
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) 
            sumRow += array[i, j];
             if (sumRow < minRow)
        {
            minRow = sumRow;
            minSumRow = i;
        }

    sumRow=0;                    // сумма больше не нужна 
    }
    Console.Write($"The row with the smallest sum of elements {minSumRow}");
}

int[,] myArray=CreateRandom2dArray();
Show2dArray(myArray);
SumOfElements(myArray); */
 
/*//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//  a1 b1  *  c1 d1 =   a1c1+b1c2   a1d1+b1d2
//  a2 b2  *  c2 d2 =   a2c1+b2c2   a2d1+b2d2

int[,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows= Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns= Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minValue= Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxValue= Convert.ToInt32(Console.ReadLine());

    int[,] array=new int[rows, columns];
    for(int i=0; i<rows;i++)
        for(int j=0; j<columns;j++)
            array[i,j] = new Random().Next(minValue,maxValue+1);
    return array;    
}
 int[,] CreateRandom2dArray2()
{
    Console.Write("Input a number of rows: ");
    int rows= Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns= Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minValue= Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxValue= Convert.ToInt32(Console.ReadLine());

    int[,] secondarray=new int[rows, columns];
    for(int i=0; i<rows;i++)
        for(int j=0; j<columns;j++)
            secondarray[i,j] = new Random().Next(minValue,maxValue+1);
    return secondarray;    
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
 void Show2dArray2( int[,] secondarray)
{
    for(int i=0; i<secondarray.GetLength(0);i++)
    {
        for(int j=0; j<secondarray.GetLength(1); j++)
            Console.Write(secondarray[i,j] + " ");

        Console.WriteLine();    
    }
}
int [,] ProductArray (int [,]array, int [,] secondarray)
{
    int [,] resultArray= new int[array.GetLength(0), secondarray.GetLength(1)];
   if (array.GetLength(0)!=secondarray.GetLength(1))
   {
    Console.WriteLine("The product of the matrix cannot be calculated");
   }
   for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < secondarray.GetLength(1); j++)
    {
        resultArray[i, j] = 0;
        for (int k = 0; k < array.GetLength(1); k++)
        {
            resultArray[i, j] += array[i, k] * secondarray[k, j];
        }
    }
}
    return resultArray;
}
int[,] myArray=CreateRandom2dArray();
Show2dArray(myArray);
int[,] myArray2=CreateRandom2dArray2();
Show2dArray2(myArray2);
Console.WriteLine("Product matrix is: ");
ProductArray(myArray,myArray2);
Show2dArray(ProductArray(myArray,myArray2));*/

/*//Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int[, ,] CreateRandom3dArray()
{
    Console.Write("Input a number of rows: ");
    int rows= Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns= Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a size3: ");
    int size3= Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minValue= Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxValue= Convert.ToInt32(Console.ReadLine());

    int[, ,] array=new int[rows, columns, size3];
    for(int i=0; i<rows;i++)
        for(int j=0; j<columns;j++)
             for(int k=0; k<size3;k++)
                array[i,j,k] = new Random().Next(minValue,maxValue+1);
    return array;    
}
void Show3dArray( int[, ,] array)
{
    for(int i=0; i<array.GetLength(0);i++)
    {
        for(int j=0; j<array.GetLength(1); j++)
        {
            for(int k=0; k<array.GetLength(2); k++)
            Console.Write("["+i+","+j+","+k+"]"+array[i,j,k] + " "); // вывод элемента с индексами
        }
        Console.WriteLine();    
    }
}
bool CheckingForNonRepetition(int[,,] array,int number)
{   
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (array[i, j, k] == number) 
                return true;
            }
        }
    }
    return false;
}
int[, ,] myArray=CreateRandom3dArray();
Show3dArray(myArray);*/

/*//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
int[,] Spiral2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows= Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns= Convert.ToInt32(Console.ReadLine());

    int[,] array=new int[rows, columns];
    int number=1;                           // заполняться будет с цифры 1
    int i=0;                                // обращение будет к индексам
    int j=0;
        while (number<=array.GetLength(0)*array.GetLength(1)) // цикл будет работать до дех пор пока не будет цифры 16 (4*4)
        {
            array[i,j] =number;                               // массив заполняется цифрами
            number++;
            if (i <= j + 1 && i + j < array.GetLength(1) - 1) 
                                 j++;
            else if (i < j && i + j >= array.GetLength(0) - 1) 
                                i++;
            else if (i >= j && i + j > array.GetLength(1) - 1) //  столбец не заполняет, переходит к строчке
                               j--;
            else
                                i--;                           // когда условия заполнения по строчке не подходят, переход к заполнению столбца
        }
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
int[,] myArray=Spiral2dArray();
Show2dArray(myArray);*/
