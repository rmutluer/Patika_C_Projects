using System;

namespace DaireCiz
{
    class Program
    {
        static void Main(string[] args)
        {
           

            Console.Write("Çizmek istediğiniz dairenin yarıçapını giriniz: ");
            int yaricap = int.Parse(Console.ReadLine());

            for (int a = -yaricap; a <= yaricap; a++)
            {
                if (a<0)
                {

                }
                for (int b = -yaricap; b <= yaricap; b++)
                {
                    if (b * b + a * a <= yaricap * yaricap)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("x");
                    }
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
