using System;

namespace FibonacciOrtalama
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ortalamasını öğrenmek istediğiniz Fibonacci Dizisinin derinliğini giriniz!");
            sayıGir: int derinlik = Convert.ToInt32(Console.ReadLine());
            if (derinlik<3)
            {
                Console.WriteLine("Lütfen 2'den büyük bir pozitif tamsayı giriniz");
                goto sayıGir;
            }
            else
            {
                int a = 0;
                int b = 1;
                double toplam = 0;
                for (int i = 0; i < derinlik-2; i++)
                {
                    int fark = b - a;
                    a = b;
                    b = b + fark;
                    toplam += a;
                    //Console.WriteLine(toplam);
                }
                Console.WriteLine($"Girdiğiniz '{derinlik}' derinliğine göre dizinin ortalaması: {toplam/derinlik} ");

            }
            Console.ReadLine();
        }
    }
}
