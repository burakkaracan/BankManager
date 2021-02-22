using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "Burak", "Ayşe", "Muaz" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            
            //isimler = new string[4];
            //isimler[3] = "Meva";
            //Console.WriteLine(isimler[3]);
            //Console.WriteLine(isimler[0]);

            List<string> isimler2 = new List<string> { "Burak", "Ayşe", "Muaz" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);

            isimler2.Add("Meva");
            Console.WriteLine(isimler2[3]);
            Console.WriteLine(isimler2[0]);
        }
    }
}
