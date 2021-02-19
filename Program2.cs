using System;

namespace array1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] car={"Audi","BmW","Tata"};
            Array.Sort(car);
            foreach (string c in car)
            {
            Console.WriteLine(c);
            }
            int[] roll={1184,646,0033,6472};
            Array.Sort(roll);
            foreach (int d in roll)
            {
            Console.WriteLine(d);
            }
        }
    }
}
