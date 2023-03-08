using System;

namespace SessizHarf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir metin giriniz:");
            string metin = Console.ReadLine();
            metin = metin.ToLower();
            bool sonuc = false;
            for (int i = 1; i < metin.Length; i++)
            {
                if (metin[i] != 'a' && metin[i] != 'e' && metin[i] != 'ı' && metin[i] != 'i' && metin[i] != 'o' && metin[i] != 'ö' && metin[i] != 'u' && metin[i] != 'ü' && metin[i - 1] != 'a' && metin[i - 1] != 'e' && metin[i - 1] != 'ı' && metin[i - 1] != 'i' && metin[i - 1] != 'o' && metin[i - 1] != 'ö' && metin[i - 1] != 'u' && metin[i - 1] != 'ü')
                {
                    sonuc = true;
                }
            }
            Console.WriteLine(sonuc);
        }
    }
}
