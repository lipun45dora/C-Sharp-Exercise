using System;

namespace math
{
    class mathconcept
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Enter two number");  
      long x=Convert.ToInt64(Console.ReadLine());
      long y=Convert.ToInt64(Console.ReadLine());
      long a=Math.Max(x,y);
      Console.WriteLine("The bigger number is ="+a);
      long z=Math.Min(x,y);  
      Console.WriteLine("The smaller number is ="+z);
       Console.WriteLine("Enter a number to get Square root of the number");  
      long p=Convert.ToInt64(Console.ReadLine());
      double s=Math.Sqrt(p);
      Console.WriteLine("The square root of "+p+" is ="+ s);
      Console.WriteLine("Enter a negative number to get absolute positive number");  
      long c=Convert.ToInt64(Console.ReadLine());
      double k=Math.Abs(c);
      Console.WriteLine("The absolute positive number of" +c+" is ="+ k);
      Console.WriteLine("Enter a  number desimal to get nearest whole number");  
      double v=Convert.ToDouble(Console.ReadLine());
      double d=Math.Abs(v);
      Console.WriteLine("The nearest whole number of" +v+" is ="+ d);
      
        }
    }
}
