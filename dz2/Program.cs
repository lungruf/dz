/*

 Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. (Проверка на трехзначность при вводе пользователем)
456 -> 5
782 -> 8
918 -> 1

 
Console.WriteLine("Ведите трех значное число");
int numb = int.Parse(Console.ReadLine()!);
int num = numb / 100;
int num1 = numb / 1000;
int srm = numb / 10 % 10; 
if (num > 0 && num1 == 0)
{
    Console.WriteLine(srm);
}
else {
     Console.WriteLine("не верное число");
}

======================================================================================================================================

 Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. (Максимум 100000)



int number = new Random().Next(1,100000);
int num = number / 100000;
int num1 = number / 10000;
int num2 = number / 1000;
int num3 = number / 100;

int number1 =  number % 10000 /1000;
int number2 =  number  % 1000 /100;
int number3=  number  % 100 / 10;
int number4=  number  % 10 ;

if (num > 0)
{
   Console.WriteLine($"третья цифра числа {number} == {number1}"); 
}
else{
    if (num1 > 0)
{
     Console.WriteLine($"третья цифра числа {number} == {number2}"); 
}
else{
    if (num2 > 0)
{
     Console.WriteLine($"третья цифра числа {number} == {number3}"); 
}
else{
    if (num3 > 0)
{
     Console.WriteLine($"третья цифра числа {number} == {number4}"); 
}
else{
     Console.WriteLine($"третья цифра числа {number} отсутствует "); 
}
}
}
}

==========================================================================================================


Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.(использовать И и ИЛИ)
6 -> да
7 -> да
1 -> нет



Console.WriteLine("напишите цифру дня недели");
int day = int.Parse(Console.ReadLine()!);

if (day > 0 && day <= 7)
{
    if (day < 6)
    {
        Console.WriteLine(day + " Это не выходной день");
    }
    else
    {
         Console.WriteLine(day + "  выходной день");
    }
}
else {
     Console.WriteLine(day + " не верный день ");
}
*/