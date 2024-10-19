//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _07_ForeachLoop
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            #region Foreach Döngüsü
//            //foreach (1;2;3;4)

//            //1:Değişken Türü
//            //2:Değişken Adı
//            //3:In
//            //4:Liste, Koleksiyon, Dizi

//            //string[] Cities = { "Milano", "Dubai", "İstanbul", "Budapeşte");
//            //foreach(var city in Cities)
//            //{
//            //    Console.WriteLine(city);
//            //}


//            //int[] number = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

//            //foreach (int numb in number)
//            //{
//            //    if (numb % 2 == 0)
//            //    {
//            //        Console.WriteLine(numb);
//            //    }

//            //}

//            //int[] number = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
//            //int total = 0;

//            //foreach (int numb in number)
//            //{
//            //    total += numb;
//            //}
//            //Console.WriteLine(total);


//            //List<int> number = new List<int>()
//            //{
//            //    1,2,3,4,5,6,7,8,9
//            //};

//            //foreach (int i in number)
//            //{
//            //    Console.WriteLine(i);
//            //}

//            //string word = "Merhaba";

//            //foreach (char c in word)
//            //{
//            //    Console.WriteLine(c);
//            //}



//            #endregion

//            #region Örnek Sınav Sistemi
//            Console.Write("********* C# Eğitim Kampı Sınav Uygulaması");
//            Console.WriteLine();
//            Console.WriteLine();
//            Console.WriteLine();
//            Console.WriteLine();


//            //Sınıftaki Öğrenci sayısını kullanıcıdan alma
//            Console.WriteLine("-----------------------------------------------------");
//            Console.Write("Sınıfınızda Kaç Öğrenci var:");
//            int studentCount=int.Parse(Console.ReadLine());
//            Console.WriteLine("-----------------------------------------------------");


//            //Öğrenci isimlerini ve not ortalamalarını saklayacak diziler.
//            string[] studentNames = new string[studentCount];
//            double[] studentExamAvg = new double[studentCount];

//            for(int i = 0; i < studentCount; i++)
//            {
//                Console.Write($"{i + 1}. öğrencinin ismini giriniz: ");
//                studentNames[i] = Console.ReadLine();
//                double totalExamResult = 0;


//                // Her öğrenci için 3 sınav notu girişi

//                for(int j = 0; j < 3; j++)
//                {
//                    Console.Write($"{studentNames[i]} isimli öğrencinin {j + 1}. sınav notunu giriniz: ");
//                    double value = double.Parse(Console.ReadLine());
//                    totalExamResult += value;//Notları Topluyoruz.

//                }

//                studentExamAvg[i] = totalExamResult / 3;

//            }

//            // Sınav Ortalamaları
//            for (int i = 0; i < studentCount; i++)
//            {
//                Console.WriteLine("-----------------------------------------------------");

//                Console.WriteLine($"{studentNames[i]} adlı öğrencinin ortalaması: {studentExamAvg[i]}");
//                // Öğrencilerin Ortalaması ve geçip kalma durumları

//                if (studentExamAvg[i] <= 100 && studentExamAvg[i] >= 85)
//                {
//                    Console.WriteLine($"{studentNames[i]} Adlı adlı öğrenci dersi geçti. Harf Notu 'A' ");
//                }

//                else if (studentExamAvg[i] <= 84 && studentExamAvg[i] >= 70)
//                {
//                    Console.WriteLine($"{studentNames[i]} Adlı adlı öğrenci dersi geçti. Harf Notu 'B' ");
//                }

//                else if (studentExamAvg[i] <= 69 && studentExamAvg[i] >= 50)
//                {
//                    Console.WriteLine($"{studentNames[i]} Adlı adlı öğrenci dersi geçti. Harf Notu 'C' ");
//                }
//                else if (studentExamAvg[i] <= 49 && studentExamAvg[i] >= 0)
//                {
//                    Console.WriteLine($"{studentNames[i]} Adlı adlı öğrenci dersten Kaldı. Harf Notu 'F' ");
//                }

//                Console.WriteLine("-----------------------------------------------------");

//            }



//            #endregion


//            Console.Read();
//        }
//    }
//}
