using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Temel Dizi Örnekleri

            //DeğişkenTürü [] diziAdi =  new DeğişkenTürü(elemansayısı)
            //string[] Colors = new string[4];
            //Colors[0] = "Kırmızı";
            //Colors[1] = "Sarı";
            //Colors[2] = "Beyaz";
            //Colors[3] = "Mavi";

            //Console.WriteLine(Colors[1]);

            //string[] Cities = new string[5];
            //Cities[0] = "Milano";
            //Cities[1] = "Budapeşte";
            //Cities[2] = "Lyon";
            //Cities[3] = "Kahire";
            //Cities[4] = "Üsküp";
            //Console.WriteLine(Cities[4]);

            //int[] numbers = new int[10];
            //numbers[0] = 50;
            //numbers[1] = 2;
            //numbers[2] = 30;
            //numbers[3] = 3;
            //numbers[4] = 40;
            //numbers[5] = 5;
            //numbers[6] = 39;
            //numbers[7] = 82;
            ////İndexte atama yapılmazsa 0 olarak döner.
            //Console.WriteLine(numbers[4]);

            //string[] Cities = { "Prag", "Budapeşte", "Roma", "Ankara", "Bursa" };
            //Console.WriteLine(Cities.Length);
            //Console.WriteLine(Cities[0]);
            #endregion

            #region Dizideki tüm elemanları listeleme

            //string[] colors = { "Beyaz", "Siyah", "Kırmızı", "Yeşil", "Mor" };
            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}

            //int[] Numbers = { 4, 54, 23, 122, 341, 551, 2331, 2235, 55555, 1235123, 5123123, 555, 11, 2, 4, 5 };
            //for (int i = 0; i < Numbers.Length; i++)
            //{
            //    if (Numbers[i] %3 == 0)
            //    {
            //        Console.WriteLine(Numbers[i]);
            //    }
            //}

            //char[] chars = { 'a', 'b', 'c', 'd', 'e', 'f' };
            //for (int i = 0; i < chars.Length; i++)
            //{

            //    Console.WriteLine(chars[i]);
            //}

            //int[] arrays = { 34, 25, 13, 46, 512, 62, 7451, 824, 91, 10, 115, 1266, 1371, 1314, 1215 };

            //int maxNumb = arrays[0];
            //for (int i = 0; i < arrays.Length; i++)
            //{
            //    if (arrays[i] > maxNumb)
            //    {
            //        maxNumb = arrays[i];
            //    }
            //}
            //Console.WriteLine(maxNumb);

            //string[] persons = { "ali", "ahmet", "Buse", "mehmet", "ceylin" };
            //Console.WriteLine(persons.Length);

            //int[] num = { 1123, 232, 13,44, 55, 2613, 57123, 5128, 519, 41120, 51112, 11232, 511233, 7164, 9815 };  
            //Array.Sort(num);
            //for (int i = 0; i < num.Length; i++) 
            //    Console.WriteLine(num[i]);


            #endregion

            #region Dizi Methodlar
            //string[] customers = { "ali", "ayse", "buse", "merve", "Çınar" }
            //int index = Array.IndexOf(customers, "merve");
            //Console.WriteLine(index);   


            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            //Console.WriteLine("Dizinin en küçük elemanı: " + numbers.Min() + " Dizinin en büyük elemanı : " + numbers.Max());



            #endregion

            #region Kullanıcıdan Değer alma

            //string[] cities = { "New York", "Ankara", "Washington", "İstanbul", "Kars" };
            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Lütfen {i+1}. Şehri Giriniz:");
            //    cities[i] = Console.ReadLine();

            //}
            //Console.WriteLine();
            //Console.WriteLine("------------------------------------------");

            //for (int i = 0;i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}

            //int[] numbers = { 10, 20, 30, 40, 50};
            //int sum= 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}
            //Console.WriteLine(sum);

            //int[] numbers = { 21, 12, 33, 45, 52, 65, 77, 81, 49, 42, 21,51,412,6123,7234,723 };
            //Console.WriteLine("Çift SAYILAR");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //    { 
            //    Console.WriteLine(numbers[i]); 
            //    }
            //}
            //Console.WriteLine("------------------------------------------");
            //Console.WriteLine("TEK SAYILAR");
            //Console.WriteLine();
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 1)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            #endregion  

              

            Console.Read();


        }
    }
}
