using System;

namespace _2022_Erdod_Peter_Problema_505
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string string1 = Console.ReadLine();
            string[] v1 = string1.Split(' ');
            string string2 = Console.ReadLine();
            string[] v2 = string1.Split(' ');
            int[] a = Array.ConvertAll(v1, int.Parse);
            int[] b = Array.ConvertAll(v2, int.Parse);
            bool ok = true;
            for (int i = 0; i < n; ++i)
            {
                bool ogl = false;
                for (int j = 0; j < n; ++j)
                    if (a[i] == b[j] && !ogl)
                    {
                        ogl = true;
                        b[j] = -1;
                    }
                if (!ogl)
                    ok = false;
            }
            if (ok)
            {
                Console.WriteLine("DA");
            }
            else
            {
                Console.WriteLine("NU");
            }
            
        }
    }
}
