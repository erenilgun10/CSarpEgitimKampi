//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Data.SqlClient;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _09_DatabaseProject
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            // ADO.net
//            Console.WriteLine("***** C# Ürün Kategori Bilgi Sistemi *****");
//            Console.WriteLine();
//            Console.WriteLine();
//            string tableNumber;
//            Console.Write("Lütfen getirmek istediğiniz tablo numarasını giriniz.");
//            Console.WriteLine("------------------------------------------------");
//            Console.WriteLine("1-Kategoriler");
//            Console.WriteLine("2-Ürünler");
//            Console.WriteLine("1-Siparişler");
//            Console.WriteLine("1-Çıkış Yap");
//            Console.Write("Lütfen numarayı girin : ");
//            tableNumber = Console.ReadLine();
//            Console.WriteLine("------------------------------------------------");

//            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-51TNQ4H;initial Catalog = EgitimKampiDb; integrated Security = true");
//            SqlCommand sqlCommand = new SqlCommand("select * from tblCategory ", connection);
//            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
//            DataTable dataTable = new DataTable();
//            sqlDataAdapter.Fill(dataTable);
//            connection.Close();
//            foreach (DataRow row in dataTable.Rows)
//            {
//                foreach (var item in row.ItemArray)
//                {

//                    if (tableNumber == "Kategoriler" || tableNumber == "1")
//                    {
//                        Console.Write(item.ToString());
                      
//                    }
                   

//                    //if (tableNumber == "Ürünler" || tableNumber == "2")
//                    //{
//                    //    Console.WriteLine(item.ToString());
//                    //}

//                    //if (tableNumber == "Siparişler" || tableNumber == "3")
//                    //{
//                    //    Console.WriteLine(item.ToString());
//                    //}

//                    //if (tableNumber == "Kategoriler" || tableNumber == "1")
//                    //{
//                    //    Console.WriteLine(item.ToString());
//                    //}
//                }
//                Console.WriteLine();
//            }

//            Console.ReadLine();
//        }
//    }
//}
