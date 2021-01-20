using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] isim = new string[] { "Ahmet", "Merve", "Elif", "Ayşe", "Hatice" };
            Console.WriteLine(isim[0]);
            Console.WriteLine(isim[1]);
            Console.WriteLine(isim[2]);
            Console.WriteLine(isim[3]);
            Console.WriteLine(isim[4]);

            List<string> isim2 = new List<string>() { "Ahmet", "Merve", "Elif", "Ayşe", "Hatice" };
            Console.WriteLine(isim2[0]);
            Console.WriteLine(isim2[1]);
            Console.WriteLine(isim2[2]);
            Console.WriteLine(isim2[3]);
            Console.WriteLine(isim2[4]);
            isim2.Add("Linda");
            Console.WriteLine(isim2[5]);
        }
    }
}
