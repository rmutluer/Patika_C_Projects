using System;

namespace AlanHesaplama
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir şekil seçin (Daire, Üçgen, Kare, Dikdörtgen):");
            string sekil = Console.ReadLine();

            double sonuc = 0;
            switch (sekil.ToLower())
            {
                case "daire":
                    Console.WriteLine("Dairenin yarıçapını girin:");
                    double yaricap = double.Parse(Console.ReadLine());
                    Console.WriteLine("Hesaplamak istediğiniz boyutu seçin (Çevre, Alan):");
                    string boyut1 = Console.ReadLine();
                    if (boyut1.ToLower() == "çevre")
                    {
                        sonuc = 2 * Math.PI * yaricap;
                        Console.WriteLine($"Dairenin çevresi: {sonuc}");
                    }
                    else if (boyut1.ToLower() == "alan")
                    {
                        sonuc = Math.PI * yaricap * yaricap;
                        Console.WriteLine($"Dairenin alanı: {sonuc}");
                    }
                    break;
                case "üçgen":
                    Console.WriteLine("Üçgenin ilk kenarını girin:");
                    double kenar1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Üçgenin ikinci kenarını girin:");
                    double kenar2 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Üçgenin üçüncü kenarını girin:");
                    double kenar3 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Hesaplamak istediğiniz boyutu seçin (Çevre, Alan):");
                    string boyut2 = Console.ReadLine();
                    if (boyut2.ToLower() == "çevre")
                    {
                        sonuc = kenar1 + kenar2 + kenar3;
                        Console.WriteLine($"Üçgenin çevresi: {sonuc}");
                    }
                    else if (boyut2.ToLower() == "alan")
                    {
                        double u = (kenar1 + kenar2 + kenar3) / 2;
                        sonuc = Math.Sqrt(u * (u - kenar1) * (u - kenar2) * (u - kenar3));
                        Console.WriteLine($"Üçgenin alanı: {sonuc}");
                    }
                    break;
                case "kare":
                    Console.WriteLine("Karenin kenar uzunluğunu girin:");
                    double kenar = double.Parse(Console.ReadLine());
                    Console.WriteLine("Hesaplamak istediğiniz boyutu seçin (Çevre, Alan):");
                    string boyut3 = Console.ReadLine();
                    if (boyut3.ToLower() == "çevre")
                    {
                        sonuc = 4 * kenar;
                        Console.WriteLine($"Karenin çevresi: {sonuc}");
                    }
                    else if (boyut3.ToLower() == "alan")
                    {
                        sonuc = kenar * kenar;
                        Console.WriteLine($"Karenin alanı: {sonuc}");
                    }
                    break;
                case "dikdörtgen":
                    Console.WriteLine("Dikdörtgenin uzun kenarını girin:");
                    double uzunKenar = double.Parse(Console.ReadLine());
                    Console.WriteLine("Dikdörtgenin kısa kenarını girin:");
                    double kısaKenar = double.Parse(Console.ReadLine());
                    Console.WriteLine("Hesaplamak istediğiniz boyutu seçin (Çevre, Alan):");
                    string boyut4 = Console.ReadLine();
                    if (boyut4.ToLower() == "çevre")
                    {
                        sonuc = 2 * (kısaKenar+uzunKenar);
                        Console.WriteLine($"Karenin çevresi: {sonuc}");
                    }
                    else if (boyut4.ToLower() == "alan")
                    {
                        sonuc = kısaKenar * uzunKenar;
                        Console.WriteLine($"Karenin alanı: {sonuc}");
                    }
                    break;

            }


        }
    }
}
