using System;

namespace Problema1
{
    class Program
    {

        static void binary(string n)
        {
            string r;
            int k = Convert.ToInt32(n);
            r = "";
            while (k > 3)
            {
                int a = k % 4;
                r = Convert.ToString(a) + r;
                k /= 4;
            }
            r = Convert.ToString(k) + r;
            Console.WriteLine("Binary: {0}", r);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("N=  ");
            string n = Console.ReadLine();
            //Console.WriteLine("Convert.ToInt32(base2, 2) = " +
            Convert.ToInt32(n, 2);
            binary(n);
        }
    
        
    }
}
