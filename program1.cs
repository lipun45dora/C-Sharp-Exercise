using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
         //Array Intialization
          string[] car={"Audi","Bmw","Toyota","Tata"};
          int[] roll={010,0233,33,44,55,86};

          // acessing array element
          Console.WriteLine(car[2]);
          Console.WriteLine(roll[4]);

          //Looping an array
          for(int i=0;i<car.Length;i++)
          {
            Console.WriteLine(car[i]);
          }
          for(int j=0;j<roll.Length;j++)
          {
            Console.WriteLine(roll[j]);
          }

          //looping using foreach
          foreach(string a in car)
           {
            Console.WriteLine(a);
          }
          foreach(int b in roll)
           {
            Console.WriteLine(b);
          }

          //Array sorting
        /*  Array.Sort(car);
foreach (string c in car)
{
  Console.WriteLine(c);
}
Array.Sort(roll);
foreach (int d in roll)
{
  Console.WriteLine(d);
}*/
        }
    }
}
