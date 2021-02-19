using System;

namespace method
{
    class method
    {
        double b;
        void balance(double bal)
        {
            bal=1000;
            bal +=b;
            Console.WriteLine(bal);
        }

        void call()
        {
            Console.WriteLine("Select your choice");
            Console.WriteLine("1.deposit");
            Console.WriteLine("2.check balance");
           int k=Convert.ToInt32(Console.ReadLine());
           if(k==1 || k==2)
           switch(k)
           {
               case 1:
               deposit();
               break;
               case 2:
               balance(b);
               break;
           }
        }
        void deposit()
        {
          Console.WriteLine("Enter your amount");  
          b=Convert.ToDouble(Console.ReadLine());
          Console.WriteLine("Sucessfully deposited");
             
             Console.WriteLine("press v to check current balance");
             Console.WriteLine("press x to exit");
             string c=Convert.ToString(Console.ReadLine());
            string d=Convert.ToString(Console.ReadLine());
            if(c=="v")
            {
                balance(b);
            }
           else if(d=="x")
           {
                Environment.Exit(0);
           }
        }
        static void Main(string[] args)
        {
           Program p=new Program();
           p.call();
           
        }
    }
}
