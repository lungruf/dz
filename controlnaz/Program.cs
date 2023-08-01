string [] bart  = new String [5] { "helow23", "2", "hi", "=)", "Element 5" };

string [] print ( string [] a){

string [] pr = new string [a.GetLength(0)];
for (int i = 0; i < pr.GetLength(0); i++)
{
    if (a[i].Length <= 3)
    {
        pr [i] = a[i];
    }
    
}
return pr;
}



string [] print2 =   print(bart);

void PrintArray(string[] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
 Console.Write($"{array[i]} ");

 Console.WriteLine();
    }

PrintArray(print2);
        
  
