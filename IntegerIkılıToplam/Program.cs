using System;

namespace IntegerIkılıToplam
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Çift sayıda 0'dan büyük pozitif tam sayı giriniz:");
            string sayilar = Console.ReadLine();
            string[] sayiDizisi = sayilar.Split(" ");
            for (int i = 1; i < sayiDizisi.Length; i++)
            {
                if (i%2!=0)
                {
                    if (sayiDizisi[i - 1] == sayiDizisi[i])
                    {
                        Console.Write(Math.Pow(2 * int.Parse(sayiDizisi[i]), 2)+" ");
                    }
                    else
                    {
                        Console.Write(int.Parse(sayiDizisi[i])+ int.Parse(sayiDizisi[i-1])+" ");
                    }
                }
                
                

            }

        }
    }
}
