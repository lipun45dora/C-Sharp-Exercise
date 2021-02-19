using System;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
          login();  
        }
        static int count=3;
        static void login()
        {
           Console.WriteLine("Enter Username");
            string name=Console.ReadLine();
            Console.WriteLine("Enter password");
            string pass=Console.ReadLine();
            if(name=="Lipundora" && pass=="3101")
            {
                Console.WriteLine("Login Sucessful");
            }
            else
            {
                Console.WriteLine("Incorrect login details");
                 count--;

                if(count>0)
                    {
                        Console.WriteLine("You have "+count+ "more chance left...");
                        Console.WriteLine();
                      login();
                    } 
               else
                    {
                        Environment.Exit(0);
                    }
            }
        }
    }
}
