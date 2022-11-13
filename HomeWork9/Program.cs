
/*// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//  n+1                                         m=0
//  Accerman (m-1,1)                            m>0,n=0
//  Accerman(m-1,Accerman(m,n-1))               m>0,n>0



int Accerman( int n, int m)
{
    if (n==0)
        return m+1;
    else 
        if ((n!=0)&&(m==0))
            return Accerman(n-1,1);
        else
            return Accerman(n-1,Accerman(n,m-1));
}
Console.WriteLine(Accerman(3,2));*/

/*//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии
void ShowNums(int n)
{
    Console.Write(n+ " ");
    if(n>1) ShowNums(n-1); 
}
ShowNums(5);*/

//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
void SumNumbers(int m, int n, int sum)
{
    if (m > n) 
    {
        Console.WriteLine($"Sum of elements : {sum}"); 
        return;
    }
    sum = sum + (m++);
    SumNumbers(m, n, sum);
}
SumNumbers(1, 5, 0);
