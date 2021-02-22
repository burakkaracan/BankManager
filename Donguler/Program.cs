using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Python";
            string kurs2 = "C Sharp";
            string kurs3 = "Java";
            
            //array - dizi

            string[] kurslar = new string[] {"Python","C Sharp","Java","C++"};
                       
            
            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("sayfa sonu - footer");
        }
    }
}
