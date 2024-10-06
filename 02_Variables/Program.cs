using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Double_Değişkenler
            //double number;
            //number = 1.40;

            //Console.WriteLine(number);

            //double applePrice, orangePrice, strawberryPrice, patatoPrice, tomatoPrice;
            //applePrice = 2.45;
            //orangePrice = 4.23;
            //strawberryPrice = 123.934;
            //patatoPrice = 31.23;
            //tomatoPrice = 23.12;
            //Console.WriteLine("----Elma Birim Fiyatı : " + applePrice);
            //Console.WriteLine("----Portakal Birim Fiyatı : " + orangePrice);
            //Console.WriteLine("----Çilek Birim Fiyatı : " + strawberryPrice);
            //Console.WriteLine("----Patates Birim Fiyatı : " + patatoPrice);
            //Console.WriteLine("----Domates Birim Fiyatı : " + tomatoPrice);


            //double appleGram, orangeGram, strawberryGram, patatoGram, tomatoGram;
            //appleGram = 1.234;
            //orangeGram = 3.122;
            //strawberryGram = 1.423;
            //patatoGram = 1.255;
            //tomatoGram = 4.000;

            //double appleTotalPrice = applePrice * appleGram;
            //double orangeTotalPrice = orangePrice * orangeGram;
            //double strawberryTotalPrice = strawberryGram * appleTotalPrice;
            //double patatoTotalPrice = patatoPrice * patatoGram;
            //double tomatoTotalPrice = tomatoGram * appleTotalPrice;
            //double totalPriceForBasket = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + tomatoTotalPrice + patatoTotalPrice;

            //Console.WriteLine( "Alınan Ürün Elma - " + "Birim Fiyat :"+ applePrice+ "Gram :"+ appleGram+"Toplam Tutar : " + appleTotalPrice);
            //Console.WriteLine( "Alınan Ürün Portakal - " + "Birim Fiyat :"+ orangePrice+ "Gram :"+ orangeGram+"Toplam Tutar : " + orangeTotalPrice);
            //Console.WriteLine( "Alınan Ürün Çilek - " + "Birim Fiyat :"+ strawberryPrice+ "Gram :"+ strawberryGram+"Toplam Tutar : " + strawberryTotalPrice);
            //Console.WriteLine( "Alınan Ürün Patates - " + "Birim Fiyat :"+ patatoPrice+ "Gram :"+ patatoGram+"Toplam Tutar : " + patatoTotalPrice);
            //Console.WriteLine( "Alınan Ürün Domates - " + "Birim Fiyat :"+ tomatoPrice+ "Gram :"+ tomatoGram+"Toplam Tutar : " + tomatoTotalPrice);
            ////Total Ücreti Gösterme

            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("Toplam sepet tutarınız: " + totalPriceForBasket);





            #endregion


            #region Char Değişkenler
            //// string ifadeler "" ile char '' ile
            //char symbol;
            //symbol = 'a';
            //Console.WriteLine(symbol);
            #endregion


            #region Klavyeden_Veri_Girişi_String_Değişkenler

            //Console.WriteLine("**** CSharp Hava Yolları Yolcu Bilgisi");
            //string customerName, customerLastName, customerDistrict, customerCity, customerAge, customerIdentityNumber;
            //Console.WriteLine("Yolcu Adı");
            //customerName= Console.ReadLine();

            //Console.WriteLine("Yolcu SoyAdı");
            //customerLastName= Console.ReadLine();

            //Console.WriteLine("İlçe Bilgisi ");
            //customerDistrict = Console.ReadLine();

            //Console.WriteLine("Şehir Bilgisi");
            //customerCity = Console.ReadLine();

            //Console.WriteLine("Yolcu Yaşı");
            //customerAge = Console.ReadLine();
            //Console.WriteLine("Yolcu Kimlik Numarası");
            //customerIdentityNumber = Console.ReadLine();


            //Console.WriteLine();


            //Console.WriteLine("--------------------------------------");
            //Console.WriteLine("Yolcu TC kimlik numarası : " + customerIdentityNumber +" Yolcu:   "+ customerName + " " + customerLastName + " " + customerDistrict + " " + customerCity + " " + customerAge );

            #endregion


            #region Klavyeden_Tam_Sayı_Girişi_Ve_Dönüşümler

            //int shoePrice, computerPrice, chairPrice, tvPrice;
            //shoePrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount, computerCount, chairCount, tvCount;
            //Console.WriteLine("Lütfen Aldığınız ayakkabı sayısını giriniz.");
            //shoesCount = int.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen aldığınız Bilgisayar sayısını giriniz.");
            //computerCount = int.Parse(Console.ReadLine());

            // Console.WriteLine("Lütfen aldığınız sandalye sayısını giriniz.");
            //chairCount = int.Parse(Console.ReadLine());

            // Console.WriteLine("Lütfen aldığınız televizyon sayısını giriniz.");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = shoesCount * shoePrice + computerPrice *computerCount + chairPrice * chairCount + tvPrice * tvCount;
            //Console.WriteLine("Toplam Tutar: " + totalPrice);

            #endregion

            #region Klavyeden_Ondalıklı_Sayı_işlemleri

            //double exam1, exam2, exam3, result;


            //Console.WriteLine("1. Sınav notunu giriniz.");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.WriteLine("2. Sınav notunu giriniz.");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.WriteLine("3. Sınav notunu giriniz.");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;


            //Console.WriteLine("Sınav Sonucunuz: " + result );

            #endregion

            #region

            //char gender;
            //Console.WriteLine("Lütfen Cinsiyet seçiniz");
            //gender = char.Parse(Console.ReadLine());
            //#endregion
            //Console.Read();

        }
    }
}
