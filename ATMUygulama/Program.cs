using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Diagnostics;

namespace ATMUygulama
{
    class Program
    {


        static void Main(string[] args)
        {
            Dictionary<string, double> accounts = new Dictionary<string, double>();
            accounts.Add("user1", 5000);
            accounts.Add("user2", 15000);
            accounts.Add("user3", 0);

            Dictionary<string, string> users = new Dictionary<string, string>();
            users.Add("user1", "1234");
            users.Add("user2", "1234");
            users.Add("user3", "1234");

            List<string> islemler = new List<string>()
        {
            "1- Para çekme","2- Para yatırma","3- Ödeme yapma","4- Çıkış yapma","5- Günsonu Alma"
        };

            string logFilePath = @"F:\ATM_Logs\EOD_" + DateTime.Now.ToString("ddMMyyyy") + ".txt";
            if (!File.Exists(logFilePath))
            {
                using (StreamWriter sw = File.CreateText(logFilePath))
                {

                    sw.WriteLine("Dosya açıldı");
                }
            }

            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz:");
            foreach (string item in islemler)
            {
                Console.WriteLine(item);
            }

            int choice = Convert.ToInt32(Console.ReadLine());


            string username = "";


            while (true)
            {
                Console.Write("Lütfen kullanıcı adınızı giriniz: ");
                username = Console.ReadLine();

                if (accounts.ContainsKey(username))
                {
                    Console.Write("Şifrenizi giriniz: ");
                    string password = Console.ReadLine();
                    if (users[username] == password)
                    {
                        break;
                    }
                    else
                    {
                        using (StreamWriter logFile = new StreamWriter(logFilePath, true))
                        {

                            logFile.WriteLine($"{username} hatalı şifre girildi");
                            logFile.WriteLine($"{DateTime.Now}");
                            // 
                            //  
                            Console.WriteLine("Hatalı Şifre");
                        }
                    }

                }

                else
                {

                    using (StreamWriter logFile = new StreamWriter(logFilePath, true))
                    {
                        logFile.WriteLine($"{username} isminde kullanıcı yok");
                        logFile.WriteLine($"{DateTime.Now}");


                        Console.WriteLine("Bu kullanıcı adı sistemde kayıtlı değil.");
                        Console.WriteLine("Lütfen tekrar deneyiniz.");
                    }
                }

            }


            switch (choice)
            {
                case 1:
                    // Para çekme işlemi
                    Console.Write("Lütfen çekmek istediğiniz tutarı giriniz: ");
                    double amountToWithdraw = Convert.ToDouble(Console.ReadLine());
                    if (accounts[username] < amountToWithdraw)
                    {

                        using (StreamWriter logFile = new StreamWriter(logFilePath, true))
                        {
                            logFile.WriteLine($"{DateTime.Now}");
                            logFile.WriteLine($"{amountToWithdraw}");
                            logFile.WriteLine("yetersiz bakiye");


                            Console.WriteLine("Hesabınızda yeterli bakiye bulunmamaktadır.");
                        }

                    }
                    else
                    {

                        using (StreamWriter logFile = new StreamWriter(logFilePath, true))
                        {
                            logFile.WriteLine($"{DateTime.Now}");
                            logFile.WriteLine($"{amountToWithdraw}");
                            logFile.WriteLine("Para çekildi");


                            accounts[username] -= amountToWithdraw;
                            Console.WriteLine("{0} TL çekildi. Yeni bakiyeniz: {1} TL", amountToWithdraw, accounts[username]);

                        }
                    }
                    break;
                case 2:
                    // Para yatırma işlemi
                    Console.Write("Lütfen yatırmak istediğiniz tutarı giriniz: ");
                    double amountToDeposit = Convert.ToDouble(Console.ReadLine());

                    using (StreamWriter logFile = new StreamWriter(logFilePath, true))
                    {
                        logFile.WriteLine($"{DateTime.Now}");
                        logFile.WriteLine($"{amountToDeposit}");
                        logFile.WriteLine("Para yatırıldı");

                        // 

                    }
                    accounts[username] += amountToDeposit;
                    Console.WriteLine("{0} TL yatırıldı. Yeni bakiyeniz: {1} TL", amountToDeposit, accounts[username]);
                    break;
                case 3:
                    // Ödeme yapma işlemi
                    Console.Write("Lütfen ödemek istediğiniz tutarı giriniz: ");
                    double amountToPay = Convert.ToDouble(Console.ReadLine());
                    if (accounts[username] < amountToPay)
                    {

                        using (StreamWriter logFile = new StreamWriter(logFilePath, true))
                        {
                            logFile.WriteLine($"{DateTime.Now}");
                            logFile.WriteLine($"{amountToPay}");
                            logFile.WriteLine("yetersiz bakiye");


                            Console.WriteLine("Hesabınızda yeterli bakiye bulunmamaktadır.");
                        }

                    }
                    else
                    {

                        using (StreamWriter logFile = new StreamWriter(logFilePath, true))
                        {
                            logFile.WriteLine($"{DateTime.Now}");
                            logFile.WriteLine($"{amountToPay}");
                            logFile.WriteLine("Ödeme yapıldı");
                            accounts[username] -= amountToPay;
                            Console.WriteLine("{0} TL ödeme yapıldı. Yeni bakiyeniz: {1} TL", amountToPay, accounts[username]);

                        }
                    }
                    break;
                case 4:
                    Console.WriteLine("Çıkış yapılıyor...");
                    break;
                case 5:
                    //Günsonu işlemi
                    Console.WriteLine("Günsonu alınıyor");

                    using (StreamReader reader = new StreamReader(logFilePath))
                    {
                        string logs;
                        while ((logs = reader.ReadToEnd()) != null)
                        {
                            Console.WriteLine(logs);
                            Console.ReadLine();
                        }

                    }
                    break;
            }
        }
    }

}
