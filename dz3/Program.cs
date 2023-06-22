/*
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да

Console.WriteLine("Ведите пятизначное число ");
int numb = int.Parse(Console.ReadLine()!);
int prov = numb / 10000;


int a = numb / 10000;
int b =  numb % 10000 / 1000;
int c = numb % 10;
int d =  numb % 100 / 10;

if (prov > 0 && prov < 10)
{
    if ( a == c && b == d)
    {
        Console.WriteLine($"число {numb} являеться палиндромом ");
    }
    else{
        Console.WriteLine($"число {numb} не являеться палиндромом ");
    }
    
}
else{
    Console.WriteLine($"число {numb} не верно ");
}



Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53


Console.WriteLine("Ведите координаты первой точки по x ");
int ax = int.Parse(Console.ReadLine()!);

Console.WriteLine("Ведите координаты первой точки по y ");
int ay = int.Parse(Console.ReadLine()!);

Console.WriteLine("Ведите координаты первой точки по z ");
int az = int.Parse(Console.ReadLine()!);


Console.WriteLine("Ведите координаты второй  точки по x ");
int bx = int.Parse(Console.ReadLine()!);


Console.WriteLine("Ведите координаты второй точки по y ");
int by = int.Parse(Console.ReadLine()!);


Console.WriteLine("Ведите координаты второй точки по z ");
int bz = int.Parse(Console.ReadLine()!);


double rasstoyn = Math.Sqrt(Math.Pow((bx - ax), 2) + Math.Pow((by - ay), 2) + Math.Pow((bz - az), 2)  );

Console.WriteLine($"Растояние от первой точки до второй равняется {rasstoyn:f2}");


Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125


Console.Write("Ведите число ");
int numb = int.Parse(Console.ReadLine()!);

for (double i = 1; i <= numb; i++)
{
   double otv = Math.Pow(i,3);
   Console.WriteLine("таблица кубов " + otv);
}

​*/