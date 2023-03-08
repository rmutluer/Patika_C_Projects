using System;

namespace Algoritma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen içinden gireceğiniz indexteki karakteri çıkartacağınız bir metin girip virgül ekledikten sonra çıkarmak istediğiniz indexi giriniz.");
            string metin = Console.ReadLine();
            if (metin.Contains(","))
            {
                string [] metinDizi= metin.Split(",");
                int index = int.Parse(metinDizi[1]);
                if (index<metinDizi[0].Length)
                {
                    for (int i = 0; i < metinDizi[0].Length; i++)
                    {
                        if (i!=index)
                        {
                            Console.Write(metinDizi[0][i]);
                        }
                    }
                    
                }
                

            }
        }
    }
}
