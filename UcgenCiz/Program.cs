using System;

namespace UcgenCiz
{
    class Program
    {
        static void Main(string[] args)
        {
            boyutGir: Console.WriteLine("Yazdırmak istediğiniz dik üçgenin yüksekliğini 2'den büyük pozitif tamsayı olarak giriniz!");
            int yukseklik = int.Parse(Console.ReadLine()); 
            if (yukseklik < 3)
            {
                Console.WriteLine("2den büyük bir sayı giriniz!");
                goto boyutGir;
            }
            else
            {
                for (int i = 1; i < yukseklik+1; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
            Console.ReadLine();
        }
    }
}
