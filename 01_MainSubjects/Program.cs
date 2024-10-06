using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region YazdırmaKomutları
            //Console.WriteLine("Merhaba Dünya :D"); //Klasik bir method ekrana yazdır :D
            //Console.Write("Selam "); // Write ile line arasındaki fark birisi yazdırdıktan sonra alt satıra iner 
            //// write ise inmez .. 

            //Console.WriteLine();
            //Console.WriteLine("********** YEMEKLER ***********");
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Soğuk Başlangıçlar");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("6-İçecekler");
            //Console.WriteLine("7-Çorbalar");
            //Console.WriteLine("********** YEMEKLER ***********");


            #endregion

            #region DEĞİŞKENLER


            // Prototip değişken oluşturma -> Değişken_türü değişken_adi

            //string name;
            //name = "Eren";
            //Console.WriteLine(name);

            //string customerName;
            //string customerSurname;
            //string customerEmail;
            //string customerPhone, customerDistrict, customerCity;

            //customerName = "Ali";
            //customerSurname = "Veli";
            //customerEmail = "deneme@deneme.com";
            //customerPhone = "+90 555 555 55 55";
            //customerDistrict = "Kadıköy";
            //customerCity = "İstanbul";

            //Console.WriteLine("******* REZERVASYON KARTI ********");
            //Console.WriteLine();
            //Console.WriteLine("----------------------------------------------");
            //Console.WriteLine("Müşteri : "+customerName + " " + customerSurname);   
            //Console.WriteLine("İletişim : "+customerPhone);   
            //Console.WriteLine("Mail Adresi : "+customerEmail);   
            //Console.WriteLine("Adres :" + customerDistrict+ "/" +customerCity);
            //Console.WriteLine("******* REZERVASYON KARTI ********");
            //Console.WriteLine("----------------------------------------------");

            //customerName = "Ayşegül";
            //customerSurname = " Ayazlı";
            //customerEmail = "test@test.com";
            //customerPhone = "+90 553 552 55 22";
            //customerDistrict = "Şile";
            //customerCity = "İstanbul";

            //Console.WriteLine();

            //Console.WriteLine("----------------------------------------------");
            //Console.WriteLine("Müşteri : " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim : " + customerPhone);
            //Console.WriteLine("Mail Adresi : " + customerEmail);
            //Console.WriteLine("Adres :" + customerDistrict + "/" + customerCity);
            //Console.WriteLine("******* REZERVASYON KARTI ********");
            //Console.WriteLine("----------------------------------------------");


            #endregion

            #region INT DEĞİŞKENLER

            //int number = 0;
            //Console.WriteLine(number);

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 100;
            int pizzaPrice = 340;
            int lemonadePrice = 125;

            int totalPrice = 0;

            int hamburgerCount = 3;
            int cokeCount = 2;
            int waterCount = 3;
            int friesCount = 35;
            int pizzaCount = 12;
            int lemonadeCount = 1233;

            Console.WriteLine("************ RESTORAN MENÜ FİYATI ****************");
            Console.WriteLine("------ Hamburger Fiyatı " + hamburgerPrice+ " Aldığınız adet "+ hamburgerCount);
            Console.WriteLine("------ Kola Fiyatı " + cokePrice + " Aldığınız  adet " + cokeCount);
            Console.WriteLine("------ Su Fiyatı " + waterPrice + " Aldığınız  adet " + waterCount);
            Console.WriteLine("------ Patates Kızartması Fiyatı " + friesPrice + " Aldığınız  adet " + friesCount);
            Console.WriteLine("------ Pizza Fiyatı " + pizzaPrice + "  Aldığınız adet " + pizzaCount); 
            Console.WriteLine("------ Limonata Fiyatı " + lemonadePrice + " Aldığınız  adet " + lemonadeCount);
            Console.WriteLine("************ RESTORAN MENÜ FİYATI ****************");


            Console.WriteLine();
            Console.WriteLine("------------------------------------");

            totalPrice = hamburgerPrice*hamburgerCount + cokePrice*cokeCount +
            waterPrice*waterCount + friesPrice*friesCount 
            + pizzaPrice*pizzaCount+ lemonadePrice*lemonadeCount;


            Console.WriteLine("Toplam Aldıklarınıza itafen ödemeniz: "+totalPrice + " TL");
            #endregion




            Console.Read(); // Konsolda entere basana kadar konsol açık kalır.
        }
    }
}
