using System;

namespace Probelma_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            n =int.Parse(Console.ReadLine());
            int[] a= new int [n];
            for (int i = 0; i < n; i++)
                a[i]=int.Parse(Console.ReadLine());
            int ca = a[0];
            int ogl = 0;
            while (ca!=0)
            {
                ogl = ogl * 10 + ca % 10;
                ca /= 10;
            }
            bool ok = false;
            for (int i = 1; i < n; i++)
                if (ogl == a[i])
                    ok = true;
            if (ok)
                Console.WriteLine("Da");
            else
                Console.WriteLine("Nu");

        }
    }
}
