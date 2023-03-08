using System;

namespace Algoritma2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir metin giriniz:");
            string metin = Console.ReadLine();
            char[] metinDizi = metin.ToCharArray();
            char ilkHarf = metin[0];
            for (int i = 1; i < metin.Length; i++)
            {
                metinDizi[i-1] = metin[i];
            }
            metinDizi[metinDizi.Length - 1] = ilkHarf;
            Console.WriteLine(metinDizi);
        }
    }
}
