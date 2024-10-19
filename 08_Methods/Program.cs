using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Metotlar
            //()
            // Geriye değer döndürmeyen metotlar.
            //Customer --> Listele, ekle, sil, güncelle
            // Void 


            //void CustomerList()
            //{
            //    Console.WriteLine("Ayşe Yıldız.");
            //    Console.WriteLine("Ali Yıldız.");
            //    Console.WriteLine("Furkan Pekdemek");
            //    Console.WriteLine("Furkan Özer");
            //}

            //CustomerList();
            //CustomerList();
            //CustomerList();
            //CustomerList();

            //void sum()
            //{
            //    int x = 1;
            //    int y = 1;
            //    int z = 1;
            //}
            //sum();

            #endregion

            #region Geriye Değer Döndürmeyen Parametreli Metotlar

            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}
            //WriteMethod("Eren");

            //void CustomerCard(string name, string surname)
            //{
            //    Console.WriteLine("Müşteri : " + name + " Soyadı: " + surname);
            //}
            //CustomerCard("Ahmet", "Yıldırım");


            #endregion

            #region Geriye Değer Döndürmeyen İnt Parametreli Metotlar
            //void Sum(int n1,int n2,int n3)
            //{

            //int result = n1 + n2+n3;
            //Console.WriteLine(result);

            //}
            //Sum(4, 123, 123);
            #endregion

            #region Geriye Değer Döndüren Methotlar

            //string CustomerName()
            //{
            //    return "Eren";

            //}
            //CustomerName();

            //string StudentCard()
            //{
            //    string Name = "Ali";
            //    string SurnName = "Çelebi";
            //    return Name + " " + SurnName;
            //}
            //Console.WriteLine(StudentCard());


            #endregion

            #region Geriye Değer Döndüren Parametreli Methotlar

            //string CountryCard(string countryName,string capital, string flagColour)
            //{
            //    string CardInfo = "Ülke : " +  countryName + " -  Başkent " + capital + "- Bayrak Rengi " + flagColour;
            //    return CardInfo;

            //}

            //string x, y, z;

            //Console.Write("Ülke Adını giriniz.");
            //x = Console.ReadLine();
            //Console.Write("Ülke Başkentini giriniz.");
            //y = Console.ReadLine();
            //Console.Write("Ülke Bayrak rengini giriniz.");
            //z = Console.ReadLine();

            //Console.WriteLine(CountryCard(x,y,z));



            #endregion

            #region Geriye Değer Döndüren İnt Parametreli Methotlar
            //int sum(int n1,int n2)
            //{
            //    int result = n1+ n2;
            //    return result;
            //}
            //Console.WriteLine(sum(98, 19));
            //Console.WriteLine(sum(938, 1519));
            //Console.WriteLine(sum(51298, 11239));
            //Console.WriteLine(sum(91238, 151239));



            #endregion

            #region Örnek Uygulama

            //string ExamResult(string student, int exam1, int exam2, int exam3)
            //{
            //    int result = (exam1 + exam2 + exam3) / 3;
            //    if (result >= 50)
            //    {
            //        return student + " isimli öğrenci sınavı geçmiştir. "+ " Ortalama : " + result;

            //    }
            //    else
            //        return student + " isimli öğrenci dersten kalmıştır. "+ " Ortalama : " + result;
                    
            //}
            //Console.WriteLine(ExamResult("ALi", 25, 34, 22));
            //Console.WriteLine(ExamResult("Ayşe", 45, 64, 82));
            #endregion


            Console.Read();
        }
    }
}
