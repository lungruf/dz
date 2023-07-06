/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными(тип double) числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9





int a = 3;


int b = 4;



double [,] GetArry (int a, int b){
    double[,] burn = new double [a , b];
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            double ban = new  Random().Next(-1,2);
            burn[i,j] =new Random().NextDouble() * 10 * ban;
            burn[i,j] = Math.Round(burn[i,j] ,1);
        
        }

    }
   return burn;
}
double [,] masr = GetArry(a , b);


void printarry (double [,] mas){
  for (int i = 0; i < mas.GetLength(0); i++)
  {
    for (int j = 0; j < mas.GetLength(1); j++)
    {
        Console.Write($"[{mas[i,j]}]");
    }
   Console.WriteLine();
   }
}

printarry(masr);


Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
i = 1, j = 2 -> 2
i = 4, j = 2 -> такого элемента не существует




Console.WriteLine("напишите первую позицию ");
int numb1 = int.Parse(Console.ReadLine()!) ;
Console.WriteLine("напишите вторую позицию ");
int numb2 = int.Parse(Console.ReadLine()!) ;

int a = 3;


int b = 5;



int [,] GetArry (int a, int b){
    int[,] burn = new int [a , b];
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            burn[i,j] =new Random().Next(1,10);

        
        }

    }
   return burn;
}
int [,] masr = GetArry(a , b);


void printarry (int [,] mas){
  for (int i = 0; i < mas.GetLength(0); i++)
  {
    for (int j = 0; j < mas.GetLength(1); j++)
    {
        Console.Write($"[{mas[i,j]}]");
    }
   Console.WriteLine();
   }
}

printarry(masr);


void grat (int [,] mas){
  int otv = 0;
  for (int i = 0; i < mas.GetLength(0); i++)
  {
    for (int j = 0; j < mas.GetLength(1); j++)
    {
        if (numb1 == i && numb2 == j)
        {
            otv = mas[i,j];
            Console.WriteLine($" на позициях {numb1} и {numb2} стоит элемент {otv}");
        }
       
    }   
  }

}
grat(masr);





















Задайте двумерный массив из целых чисел. Найдите среднее арифметическое* элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
* Сумма всех цифр / их количество(это количество ваших строк)

*/

