using System;

namespace KarakterDegistirme
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir metin giriniz:");
            string metin = Console.ReadLine();
            char[] metinDizi = metin.ToCharArray();
            char ilkHarf = metin[0];
            metinDizi[0] = metinDizi[metinDizi.Length - 1];
            metinDizi[metinDizi.Length - 1] = ilkHarf;
            Console.WriteLine(metinDizi);
        }
    }
}
