using System;

namespace stringex
{
    class Program
    {
        static void Main(string[] args)
        {
            //string declaration
            string a="ahbdhnvhiojiojmcklwk";

             //acessing string
              Console.WriteLine(a[4]);

             //string methods
              Console.WriteLine("Enter a string value");
              string s=Convert.ToString(Console.ReadLine());
              Console.WriteLine("Length ="+s.Length);
              Console.WriteLine("To uppercase ="+s.ToUpper());
              Console.WriteLine("To lowercase ="+s.ToLower());
               Console.WriteLine("Substring ="+s.Substring(0,5));

               //String cooncatination
               Console.WriteLine("Enter your first name");
              string b=Convert.ToString(Console.ReadLine());
              Console.WriteLine("Enter your last name");
              string c=Convert.ToString(Console.ReadLine());
              string d=string.Concat(b,c);
              Console.WriteLine("Concatination using concat method= "+d);
              string e=c+d;
              Console.WriteLine("Concatination using + sign= "+e);

              //string interpolation
              Console.WriteLine("Enter your first name");
              string f=Convert.ToString(Console.ReadLine());
              Console.WriteLine("Enter your last name");
              string g=Convert.ToString(Console.ReadLine());
              string h=$"My full name is: {f} {g}";
              Console.WriteLine(h+"  // Using interpolation");


           
        }
    }
}
