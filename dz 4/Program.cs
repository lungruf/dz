// -------------------------------------------ВСЕ РЕШАТЬ ЧЕРЕЗ МЕТОДЫ---------------------------------------------------
/*

Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16

Console.WriteLine("число 1");
int num1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("число 2");
int num2 = int.Parse(Console.ReadLine()!);

double alertd (int a,int b){
  double count= 0;
  if (b > 0)
  {
    count = Math.Pow(a,b);
  }
  return count;
}

Console.WriteLine(alertd(num1,num2));

Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12


Console.WriteLine("число ");
int num1 = int.Parse(Console.ReadLine()!);


int sar (int num){
    int resol = 0;

    while (num > 0)
    {
        resol = num % 10 + resol;
        num = num / 10;

    }
    return resol;

}
Console.WriteLine($"Сумма цифр в числе {num1} равна {sar(num1)}");


 Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. (можно указать любой промежуток)
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]



Console.WriteLine("число ");
int elem = int.Parse(Console.ReadLine()!);

int [] mass (int a){
    int [] mas1 = new int [a];

    for (int cons = 0; cons < a; cons++)
    {
        mas1[cons] = new Random().Next(1,99);
    }
    return mas1;
}

int [] arry = mass(elem);
string otv = string.Join("," , arry);

Console.WriteLine(otv);

*/