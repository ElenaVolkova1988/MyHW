/*// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. 456 -> 5; 782 -> 8; 918 -> 1
 
    int TwoDigit ( int number)
{ 
    if (number<1000 && number >=100)
{
      int res= (number/10)%10;
      Console.WriteLine($"The second digit {res}");
}  
    else 
{
      Console.WriteLine("ERROR");
}                                             
    return number;
}
    Console.WriteLine ("Input a number");
    int number = Convert.ToInt32(Console.ReadLine());
    int twoDigit=TwoDigit (number);*/
    

 /*
 //13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.645 -> 5 ; 78 -> третьей цифры нет; 32679 -> 6

    int MultiPleNumber (int num)
{
      if (num<1000 && num>=100)
{
        int res = num%10;
        Console.WriteLine($"The third digit is {res}");
}
      else 
{
        Console.WriteLine("The third digin is missing") ;
}
      return num;
}
    Console.WriteLine ("Input a number");
    int num = Convert.ToInt32(Console.ReadLine());
    int multiPleNumber = MultiPleNumber (num);
 */

//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.6 -> да;7 -> да;1 -> нет

    int WeekDay (int num)
{
    if (num >0 && num <8)
{
      if (num<=5)
{
      Console.WriteLine("No");
}
      if (num==6 || num==7)
{
      Console.WriteLine("Yes");
}
}
    else
{
    Console.WriteLine("ERROR");
}
   
    return num;
}
    Console.WriteLine ("Input a number");
    int num = Convert.ToInt32(Console.ReadLine());
    int weekDay = WeekDay (num);