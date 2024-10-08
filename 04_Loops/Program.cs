using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For Döngüsü

            // For Döngüsü -> (;;;) 3 parametre
            //int i;

            //for (i = 1; i <= 15; i++)
            //{
            //    Console.WriteLine("İ değeri :" + i);
            //}

            //for (i = 3; i < 50; i+=3) 
            //{
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine("Ekrana yazılmasını istediğiniz değeri giriniz...");

            //int finishValue = int.Parse(Console.ReadLine());
            //for (i = 1; i <= finishValue; i++)
            //{
            //    Console.WriteLine("Yaşasın Cumhuriyet!!!");
            //}


            #endregion

            #region For Döngüsü ile Karar yapıları..


            //for (int i = 0; i < 200; i++)
            //{
            //    if (i % 5 == 0) 
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //int totalValue = 0;


            //for (int i = 1; i <= 19; i++)
            //{
            //    totalValue += i;
            //}
            //Console.WriteLine(totalValue);

            // int totalValue = 0;


            //for(int i  = 0; i < 20; i++)
            // {
            //     if(i % 2 == 0)
            //     {
            //         totalValue += i;
            //         Console.WriteLine(i);
            //     }
            // }
            // Console.WriteLine(totalValue);

            //int count = 0;


            //for (int i = 0; i < 50; i++)
            //{
            //    if (i % 7 == 0)
            //    {
            //        count++;

            //    }
            //}
            //Console.WriteLine(count);


            // 1 - 2 - 4 - 8 - 16

            //int bakteri = 1;


            //for (int i = 0; i < 24; i++) 
            //{
            //  bakteri *= 2;
            //}

            //Console.WriteLine(bakteri);



            #endregion

            #region While Döngüsü
            //int i = 0;
            //while  (i <= 10 )
            //{

            //    Console.WriteLine("merhaba dünya");
            //    i++;
            //}

            //int i = 1;

            //while (i <= 10)
            //{
            //    if(i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;

            //}

            //int i = 1;

            //int sum = 0;

            //while (i > 0)
            //{
            //    sum += i;
            //    i++;
            //}
            //Console.WriteLine(sum); 




            #endregion


            #region Örnek Sınav Sorusu

            //1- Basamaklar toplamı yüzdelik 3. bas 100 2. bas 10 1. bas 1 
            //Console.WriteLine("Sayıyı giriniz");
            //int sayi = int.Parse(Console.ReadLine());

            //int yuz, on, bir;

            //bir = sayi % 10;
            //on = (sayi % 100) - bir;
            //yuz = sayi - (bir + on);

            //Console.WriteLine("Sayınızın yüzler basamağı : " + yuz + "\n"
            //    + " Onlar basamağı : " + on + "\n"
            //    + " Birler basamağı : " + bir + "\n"
            //    + " Sayınız : " + (yuz + on + bir));

            //2- Basamaklar toplamı tek.

            //Console.WriteLine("Sayıyı giriniz");
            //int sayi = int.Parse(Console.ReadLine());

            //int yuz, on, bir;

            //bir = sayi % 10;
            //on = ((sayi % 100) - bir)/10;
            //yuz = (sayi - (bir + on))/100;

            //Console.WriteLine("Sayınızın yüzler basamağı : " + yuz + "\n"
            //    + " Onlar basamağı : " + on + "\n"
            //    + " Birler basamağı : " + bir + "\n"
            //    + " Sayınız : " + (yuz + on + bir));



            #endregion



            Console.Read();
        }
    }
}
