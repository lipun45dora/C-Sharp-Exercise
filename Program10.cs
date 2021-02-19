using System;

namespace star2
{
    class Program
    {
        static void Main(string[] args)
        { int row=5;
            for(int i=0;i<row;i++)
            {
                for(int j=2*(row-i); j>=0; j--)
                {
                    Console.Write(" ");
                }
                for(int k=0;k<=i;k++)
                {
                //Console.WriteLine();
                Console.Write("* ");
                }
                Console.WriteLine();
              
              //Console.WriteLine();
            }
        }
    }
}
