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

