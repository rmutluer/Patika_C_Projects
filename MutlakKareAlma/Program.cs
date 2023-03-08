using System;

namespace MutlakKareAlma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" 0'dan büyük pozitif tam sayılar giriniz:");
            string sayilar = Console.ReadLine();
            string[] sayiDizisi = sayilar.Split(" ");
            int toplamKucuk = 0;
            double toplamBuyuk = 0;
            for (int i = 0; i < sayiDizisi.Length; i++)
            {
                if (int.Parse(sayiDizisi[i])<67)
                {
                    toplamKucuk += (67-int.Parse(sayiDizisi[i]));
                }
                else
                {
                    toplamBuyuk += Math.Pow((double.Parse(sayiDizisi[i]) - 67), 2);
                }
            }
            Console.WriteLine($"67den küçük olan sayıların farkları toplamı:{toplamKucuk}, 67den büyük olanların farklarının kareleri toplamı:{toplamBuyuk}");
        }
    }
}
