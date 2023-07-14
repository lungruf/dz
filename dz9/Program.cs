
/*
Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

 int a = 1;
  int b =5;
 void recurs ( int start, int end){
    if (end > start)
    {
      return;
    }
    else{
      recurs(start,end +1);
      Console.Write(end  + ",");
    }
 }


recurs(b,a);





Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30

 int a = 15;
  int b =1;
 int recurs ( int start, int end){
    if (start == end) return start;
   return (start + recurs(start+1,end));
 }


Console.WriteLine(recurs(b,a));
*/