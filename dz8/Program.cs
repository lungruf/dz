/*Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2






int [,] GlobalMass (int a , int b){
    int [,] mas = new int [a,b];
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            mas [i,j] = new Random().Next(1,10);
        }
    }
    return mas;
}

int [,] fart = GlobalMass(3,3);


void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength( 1);j++)
        {
 Console.Write($"{array[i, j]} ");
        }
 Console.WriteLine();
    }
}

PrintArray(fart);


void SortToLower(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1);j++)
        {
            for (int v = 0; v < array.GetLength(1)-1;v++)
            {
                if (array[i, v] < array[i, v + 1])
                {
                int count = array[i, v + 1];
                   array[i, v + 1] = array[i, v];
                   array[i, v] = count;
                }
            }
        }
    }
}


SortToLower(fart);
Console.WriteLine();
PrintArray(fart);




Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.



int [,] GlobalMass (int a , int b){
    int [,] mas = new int [a,b];
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            mas [i,j] = new Random().Next(1,10);
        }
    }
    return mas;
}

int [,] fart = GlobalMass(2,2);

void ArrayPrint (int [,] caunt){
    for (int i = 0; i < caunt.GetLength(0); i++)
    {
        for (int j = 0; j < caunt.GetLength(1); j++)
        {
            Console.Write($"[{caunt[i,j]}]");
        }
        Console.WriteLine();
    }
}

ArrayPrint(fart);
 Console.WriteLine();

int [,] fart1 = GlobalMass(2,2);



ArrayPrint(fart1);


int [,] GlobalMass1 (int a , int b){
    int [,] mas = new int [a,b];
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            mas [i,j] = fart1[i,j] * fart[i,j];
        }
    }
    return mas;
}

int [,] fart2 = GlobalMass1(fart1.GetLength(0),fart1.GetLength(1));

Console.WriteLine();
ArrayPrint(fart2);





Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

int [, , ] GlobalMass (int a , int b , int g){
    int [, , ] mas = new int [a,b,g];
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            for (int k = 0; k < g; k++)
            {
                mas [i,j,k] = new Random().Next(1,10);
            }
        }
    }
    return mas;
}

int [, ,] fart = GlobalMass(2,2,2);

void ArrayPrint (int [, ,] caunt){
    for (int i = 0; i < caunt.GetLength(0); i++)
    {
        for (int j = 0; j < caunt.GetLength(1); j++)
        {
            for (int k = 0; k < caunt.GetLength(2); k++)
            {
                Console.Write($"[{caunt[i,j,k] } ({i},{j},{k})]");
            }
        }
        Console.WriteLine();
    }
}

ArrayPrint(fart);
 Console.WriteLine();