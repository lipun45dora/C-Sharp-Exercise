using System;

namespace switchex
{
    class Program
    {
        string p;
        string e;
        void input()
        {
            Console.WriteLine("Enter two number");
            long l=Convert.ToInt64(Console.ReadLine());
            long m=Convert.ToInt64(Console.ReadLine());
           
           //long l=this.x;
            //long m=this.y;
            Console.WriteLine("Select your operation");
            Console.WriteLine("1.For addition press +");
            Console.WriteLine("2.For substraction press -");
            Console.WriteLine("1.For multiplicationn press *");
            Console.WriteLine("1.For Division press / ");
            string s=Convert.ToString(Console.ReadLine());
            if(s=="+" || s=="-" || s=="*" || s=="/")
            {
                switch(s)
                {
                    case "+":
                    
                        long z=l+m;
                        Console.WriteLine("Addition of "+l+ " and "+m+" ="+z );
                        Console.WriteLine("Press R to restart");
                         Console.WriteLine("Press x to exit");
                  e=Convert.ToString(Console.Read());
                  p=Convert.ToString(Console.Read());
                 if(e=="R")
                 {
                     input();
                 }
                 else if(p=="x")
                 {
                     Environment.Exit(0);
                 }
                    break;
                    case "-":
                    
                        long a=l-m;
                        Console.WriteLine("substraction of "+l+ " and "+m+" ="+a );
                        Console.WriteLine("Press R to restart");
                         Console.WriteLine("Press x to exit");
                  e=Convert.ToString(Console.Read());
                  p=Convert.ToString(Console.Read());
                 if(e=="R")
                 {
                     input();
                 }
                 else if(p=="x")
                 {
                     Environment.Exit(0);
                 }
                    break;
                    case "*":
                    
                        long b=l*m;
                        Console.WriteLine("Multiplication of "+l+ " and "+m+" ="+b );
                        Console.WriteLine("Press R to restart");
                         Console.WriteLine("Press x to exit");
                  e=Convert.ToString(Console.Read());
                  p=Convert.ToString(Console.Read());
                 if(e=="R")
                 {
                     input();
                 }
                 else if(p=="x")
                 {
                     Environment.Exit(0);
                 }
                    break;
                    case "/":
                    
                        long c=l+m;
                        Console.WriteLine("Division of "+l+ " and "+m+" ="+c );
                        Console.WriteLine("Press R to restart");
                         Console.WriteLine("Press x to exit");
                  e=Convert.ToString(Console.Read());
                  p=Convert.ToString(Console.Read());
                 if(e=="R")
                 {
                     input();
                 }
                 else if(p=="x")
                 {
                     Environment.Exit(0);
                 }
                    break;
                }
            }
            else
            {
                Console.WriteLine("Invalid operation.");
                 Console.WriteLine("Press R to restart");
                  e=Convert.ToString(Console.ReadLine());
                 if(e=="R")
                 {
                     input();
                 }
                 {
                     Environment.Exit(0);
                 }
            }
        }
        static void Main(string[] args)
        {
            Program k=new Program();
            k.input();
        }
    }
}
