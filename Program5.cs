using System;
using System.Linq;
namespace Linqarray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array size");
            int x=Convert.ToInt32(Console.ReadLine());
            int[] arr=new int[x];
            Console.WriteLine("Enter array elements");
            for(int i=0;i<arr.Length;i++)
            {
               arr[i]=Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Largest value="+arr.Max());  // returns the largest value
      Console.WriteLine("Smallest value="+arr.Min());  // returns the smallest value
      Console.WriteLine("Total sum="+arr.Sum()); 
        }
    }
}
