# Сначало создаем массив  
###  
    string [] bart  = new String [5]
#  Вторым действием заполняем наш массив данными
### 
    string [] bart  = new String [5] { "helow23", "2", "hi", "=)", "Element 5" };

# Тетьем действие создали функцию создания второго массива и распределение в него данных 

###  
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


# Вывод финального массива
   ### 
        string [] print2 =   print(bart);

        void PrintArray(string[] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
                    Console.Write($"{array[i]} ");

            Console.WriteLine();
          }

           PrintArray(print2);
        


