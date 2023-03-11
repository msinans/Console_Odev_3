using System;

namespace Console_Odev_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dortislem di = new Dortislem();
            int t1, t2;
            double d1, d2;
            Console.Write("Bir sayı girin: ");
            t1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Bir sayı girin: ");
            t2 = Convert.ToInt32(Console.ReadLine());
            d1 = Convert.ToDouble(t1);
            d2 = Convert.ToDouble(t2);

            di.Topla(t1, t2);                        
            di.Cikar(t1, t2);
            di.Bol(d1, d2);
            di.Carp(t1, t2);
            di.Mod(t1, t2);

            Console.Read();
        }
    }
}
