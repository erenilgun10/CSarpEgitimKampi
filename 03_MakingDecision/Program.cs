using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region IF ELSE


            //Console.WriteLine("Lütfen Şifreyi giriniz.");
            //string password;
            //password = Console.ReadLine();
            //if (password == "abcd")
            //{
            //    Console.WriteLine("Şifre Doğru");

            //}
            //else
            //{
            //    Console.WriteLine("Şifre Yanlış");
            //}

            //Console.WriteLine("Başkenti Giriniz: ");
            //string capital = Console.ReadLine();

            //Console.WriteLine("Ülkeyi giriniz");
            //string country = Console.ReadLine();

            //if (capital == "Ankara" && country == "Türkiye")
            //{
            //    Console.WriteLine("Doğru ülkeyi ve şehri girdiniz");
            //}
            //else
            //{
            //    Console.WriteLine("Yanlış girdiniz...");
            //}

            //int number;

            //Console.WriteLine("Sayı Giriniz: ");
            //number = int.Parse(Console.ReadLine());
            //if (number == 5) 
            //{
            //    Console.WriteLine("Sayınız 5 e eşittir...");
            //}
            //else
            //{
            //    Console.WriteLine("Sayınız 5'e eşit değildir...");
            //}


            //int exam1, exam2, exam3, avg;
            //string result = "Öğrenci sınava girmemiştir...";

            //Console.WriteLine("Sınav1");
            //exam1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Sınav2");
            //exam2 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Sınav3");
            //exam3 = int.Parse(Console.ReadLine());

            //avg = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine("Sınavların Ortalaması : " + avg);


            //if (avg > 0 && avg <= 50) result ="Sonuç : Vasat";
            //if (avg > 50 && avg <= 70) result = "Sonuç : Orta";
            //if (avg > 70 && avg <= 84) result = "Sonuç : İyi";
            //if (avg > 84 ) result =  "Sonuç : Çok iyi";
            //Console.WriteLine(result);


            //string city;
            //Console.WriteLine("Lütfen şehir girişi yapınız");
            //city = Console.ReadLine();
            //if (city == "Adana" | city == "Bursa" | city == "Eskişehir" | city == "Lüleburgaz")
            //{
            //    Console.WriteLine("Şehir mevcuttur...");
            //}
            //else
            //{
            //    Console.WriteLine("Şehir mevcut değildir.");
            //}

            //Console.WriteLine("Lütfen Kullanıcı Adı giriniz.");
            //string username = Console.ReadLine();
            //if (username != "Admin")
            //{
            //    Console.WriteLine("Bu kullanıcı Adı kabul edilemez...");
            //}
            //else
            //{
            //    Console.WriteLine("Hoş geldin Admin kardeş...");
            //} 


            #endregion


            #region MOD işlemleri


            //int number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);

            //Console.WriteLine("1. sayıyı giriniz...");
            //int number1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("2. sayıyı giriniz...");
            //int number2 = int.Parse(Console.ReadLine());


            //int result = number1 % number2;
            //Console.WriteLine("1. sayının 2. sayıya bölümünden kalan : " + result);
            #endregion


            #region Char işlemleriyle Karar Yapıları

            //char team;
            //Console.Write("Lütfen takım sembolünü giriniz");
            //team = char.Parse(Console.ReadLine());

            //if(team == 'g' | team == 'G')
            //{
            //    Console.WriteLine("Gaziantep");
            //}

            //if(team == 'f' | team == 'F')
            //{
            //    Console.WriteLine("Fenerbahçe");
            //}

            //if(team == 'b' | team == 'B')
            //{
            //    Console.WriteLine("Beşiktaş");
            //}

            #endregion


            #region Ornek Proje uygulaması

            //Console.WriteLine(" ***************** C# Eğitim Kampı Restoran ******************** ");
            //Console.WriteLine();
            //Console.WriteLine("-------------------------------------");
            //Console.WriteLine("1-Ana Yemekler");
            //Console.WriteLine("2-Çorbalar");
            //Console.WriteLine("3-Pizzalar");
            //Console.WriteLine("4-İçecekler");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("-------------------------------------");
            //Console.WriteLine();

            //string menuItem;

            //Console.WriteLine("Detayını Görmek İstediğiniz menü seçimi.");
            //menuItem = Console.ReadLine();

            //if (menuItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine(" ----------------- ANA YEMEKLER -----------------");
            //    Console.WriteLine("1. Köri Soslu Tavuk");
            //    Console.WriteLine("2. Kızartma Tabağı");
            //    Console.WriteLine("3. Fasulye Pilav");
            //    Console.WriteLine("4. Fırında Somon");
            //    Console.WriteLine("5. Patlıcan Musakka");
            //    Console.WriteLine(" ----------------- ANA YEMEKLER -----------------");

            //}
            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine(" ----------------- ÇORBALAR -----------------");
            //    Console.WriteLine("1. Ezogelin Çorbası");
            //    Console.WriteLine("2. Mercimek Çorbası");
            //    Console.WriteLine("3. Analı Kızlı Çorbası");
            //    Console.WriteLine("4. Tarhana Çorbası");
            //    Console.WriteLine("5. Yüksük Çorbası");
            //    Console.WriteLine(" ----------------- ÇORBALAR -----------------");

            //}      
            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine(" ----------------- PİZZALAR -----------------");
            //    Console.WriteLine("1. Margaria Pizza");
            //    Console.WriteLine("2. Sade Sucuklu Pizza");
            //    Console.WriteLine("3. Karışık Pizza");
            //    Console.WriteLine("4. Kavurmalı Pizza");
            //    Console.WriteLine("5. Akdeniz Pizza");
            //    Console.WriteLine(" ----------------- PİZZALAR -----------------");

            //}       
            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine(" ----------------- İÇECEKLER -----------------");
            //    Console.WriteLine("1. Su");
            //    Console.WriteLine("2. Ayran");
            //    Console.WriteLine("3. Kola");
            //    Console.WriteLine("4. Şalgam");
            //    Console.WriteLine("5. Meyve Suyu");
            //    Console.WriteLine(" ----------------- İÇECEKLER -----------------");

            //}         
            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine(" ----------------- TATLILAR -----------------");
            //    Console.WriteLine("1. Kemal Paşa Tatlısı");
            //    Console.WriteLine("2. Revani");
            //    Console.WriteLine("3. Kuruvasan ");
            //    Console.WriteLine("4. Baklava");
            //    Console.WriteLine("5. Halka Tatlısı");
            //    Console.WriteLine(" ----------------- TATLILAR -----------------");

            //}


            #endregion


            #region Switch - Case Yapıları

            //Console.WriteLine("Ay girişi yapınız");
            //int monthNumber = int.Parse(Console.ReadLine());
            //switch(monthNumber)
            //{
            //    case 1: Console.WriteLine("Ocak"); break;
            //    case 2: Console.WriteLine("Şubat"); break;
            //    case 3: Console.WriteLine("Mart"); break;
            //    case 4: Console.WriteLine("Nisan"); break;
            //    case 5: Console.WriteLine("Mayıs"); break;
            //    case 6: Console.WriteLine("Haziran"); break;
            //    case 7: Console.WriteLine("Temmuz"); break;
            //    case 8: Console.WriteLine("Ağustos"); break;
            //    case 9: Console.WriteLine("Eylül"); break;
            //    case 10: Console.WriteLine("Ekim"); break;
            //    case 11: Console.WriteLine("Kasım"); break;
            //    case 12: Console.WriteLine("Aralık"); break;

            //    default: Console.WriteLine("Hatalı bilgi girişi"); break;
            //}

            #endregion


            #region Switch - Case Hesap Makinesi

            //int n1, n2, result;
            //char syb;

            //Console.WriteLine("1. Sayıyı giriniz.");
            //n1 = int.Parse(Console.ReadLine());
            
            //Console.WriteLine("2. Sayıyı giriniz.");
            //n2 = int.Parse(Console.ReadLine());
            
            //Console.WriteLine("Yapmak istediğiniz işlemi giriniz.");
            //syb = char.Parse(Console.ReadLine());


            //switch (syb)
            //{

            //    case '+':
            //        result = n1 + n2; 
            //        Console.WriteLine("Toplam" + result);
            //        break;
                    
            //    case '-':
            //        result = n1 - n2; 
            //        Console.WriteLine("Fark" + result);
            //        break;
                    
            //    case '/':
            //        result = n1 / n2; 
            //        Console.WriteLine("Bölüm" + result);
            //        break;
                    
            //    case '*':
            //        result = n1 * n2; 
            //        Console.WriteLine("Çarpım" + result);
            //        break;

                    
            //}


            #endregion


            Console.ReadLine();
        }
    }
}
