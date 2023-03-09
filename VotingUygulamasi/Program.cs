using System;
using System.Collections.Generic;

namespace VotingUygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> categories = new List<string>() { "Film Kategorileri", "Tech Stack Kategorileri", "Spor Kategorileri" };
            Dictionary<string, int> users = new Dictionary<string, int>();
            Dictionary<string, int> votes = new Dictionary<string, int>();



            Console.WriteLine("Oylama Uyglamasına Hoşgeldiniz!");
            Basla: Console.WriteLine("Lütfen kullanıcı adınızı girer misiniz?:");
            string username = Console.ReadLine();
            if (!users.ContainsKey(username))
            {
                users.Add(username, 0);
                Console.WriteLine($"Kullanıcı {username} eklendi!\n Yeniden yönlendiriliyorsunuz.");
                goto Basla;
            }
            else
            {
                if (users[username] >= 1)
                {
                    Console.WriteLine("Zaten oylama yapmışsınız, uygulamayı kullandığınız için teşekkür ederiz");
                    goto Sonuc;
                }
                else
                {
                    Secim: Console.WriteLine("\nLütfen oy vermek istediğiniz kategoriyi seçin:");

                    for (int i = 0; i < categories.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {categories[i]}");
                    }
                    int choice = Convert.ToInt32(Console.ReadLine());

                    if (choice < 1 || choice > categories.Count)
                    {
                        Console.WriteLine("Geçersiz seçim. Lütfen tekrar deneyin.");
                        goto Secim;
                    }
                    else
                    {
                        string category = categories[choice - 1];
                        if (!votes.ContainsKey(category))
                        {
                            votes.Add(category, 0);
                        }
                        votes[category]++;
                        users[username]++;
                        Console.WriteLine($"\nTeşekkür ederiz, {username}! Oyunuz kaydedildi.");

                    }
                }
            }
            Sonuc: Console.WriteLine("\nOylama sonuçları:");

            foreach (string category in categories)
            {
                int totalVotes = votes.ContainsKey(category) ? votes[category] : 0;
                double percentage = totalVotes / (double)votes.Count * 100;

                Console.WriteLine($"{category}: {totalVotes} oy ({percentage}% of total votes)");
            }
            Console.WriteLine("\n Oy vermek ister misiniz? (E/H)");

            string answer = Console.ReadLine();

            if (answer.ToLower() == "e")
            {
                goto Basla;
            }
            else
            {
                Console.WriteLine("\nProgram sonlandırıldı. İyi günler!");
            }
            Console.ReadLine();
        }
    }
}
