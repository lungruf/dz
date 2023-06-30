//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

/*
 int syze = new Random().Next(2,9);

 int [] mass (int a){
   
   int [] bor = new int [a];
   for (int i = 0; i < a; i++)
   {
    bor[i]= new Random().Next(100,1000);
   }
   return bor;
 }

 int [] mas1 = mass(syze);

string otv1 = string.Join("," , mas1);
Console.WriteLine($"[{otv1}]");

int count = 0;

for (int i = 0; i < syze -1; i++)
{
    if ( mas1[i] % 2 == 0 )
    {
        count++;
    }
}
Console.WriteLine($"Количество четных чисел в массиве [{otv1}] равно {count}");




Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных ИНДЕКСАХ.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0


int syze =4;

 int [] mass (int a){
   
   int [] bor = new int [a];
   for (int i = 0; i < a; i++)
   {
    bor[i]= new Random().Next(100,1000);
   }
   return bor;
 }

 int [] mas1 = mass(syze);

string otv1 = string.Join("," , mas1);
Console.WriteLine($"[{otv1}]");

int count = 0;

for (int i = 0; i < syze ; i++)
{
    if (i % 2 > 0)
    {
        count = mas1[i] + count;
    }
}

Console.WriteLine($"сумма элементов, стоящих на нечётных ИНДЕКСАХ = {count}");



Задайте массив целых двухзначных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[22, 42, 15, 77, 65] => 77 - 15 = 62**


int syze =new Random().Next(2,9);;

 int [] mass (int a){
   
   int [] bor = new int [a];
   for (int i = 0; i < a; i++)
   {
    bor[i]= new Random().Next(10,100);
   }
   return bor;
 }

 int [] mas1 = mass(syze);

string otv1 = string.Join("," , mas1);
Console.WriteLine($"[{otv1}]");

int max = mas1[0];

int min = mas1[0];


foreach (int item in mas1)
{
    if (item > max)
    {
        max = item;
    }
    else
    {
      if (item < min)
      {
        min = item;
      }
    }
}
Console.WriteLine($"разница между максимальным и минимальным элементоа массива равна {max} - {min} = {max - min} ");

*/