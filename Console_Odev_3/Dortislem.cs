using System;

namespace Console_Odev_3
{
    internal class Dortislem
    {
        public int Topla(int t1, int t2)
        {
            int t3 = t1 + t2;
            Console.WriteLine("Toplam: " + t3);
            return t3;
        }
        public int Cikar(int t1, int t2)
        {
            int t3 = t1 - t2;
            Console.WriteLine("Fark: " +  t3);
            return t3;
        }
        public double Bol(double t1, double t2)
        { 
            double t3 = t1 / t2;
            Console.WriteLine("Bölüm: " + t3.ToString("0.00"));
            return t3;
        }
        public int Carp(int t1, int t2)
        {
            int t3 = t1 * t2;
            Console.WriteLine("Çarpım: " + t3);
            return t3;            
        }
        public int Mod(int t1, int t2)
        {
            int t3 = t1 % t2;
            Console.WriteLine("Bölümden Kalan: " + t3);
            return t3;
        }

    }
}
