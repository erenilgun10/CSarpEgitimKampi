using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Kategori Ekleme İşlemi
            ////--> Create--Read-update--Delete


            //Console.WriteLine("***** Menü Sipariş İşlem Paneli *****");
            //Console.WriteLine();

            //Console.WriteLine("-----------------------------------------");
            //Console.Write("Eklemek istediğiniz Kategori Adı : ");

            //string categoryName = Console.ReadLine();

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-51TNQ4H;initial catalog = EgitimKampiDb; integrated security = true");
            //connection.Open();
            //SqlCommand sqlCommand = new SqlCommand("insert into TblCategory (CategoryName) values (@p1)", connection);
            //sqlCommand.Parameters.AddWithValue("@p1", categoryName);
            //sqlCommand.ExecuteNonQuery();
            //connection.Close();
            //Console.WriteLine("Kategori başarıyla eklendi");

            #endregion

            #region Ürün Ekleme İşlemi

            //string productName;
            //decimal productPrice;
            //string productStatus;

            //Console.Write("Ürün Adı: ");
            //productName = Console.ReadLine();

            //Console.Write("Ürün Fiyatı : ");
            //productPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("data source=DESKTOP-51TNQ4H;initial catalog=EgitimKampiDb;integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into TblProduct (CategoryName) values (Productname,ProductPrice,ProductStatus) values" +
            //    " (@productName,@productPrice,@productStatus)", connection);


            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productStatus", true);
            //connection.Close();
            //Console.WriteLine("Ürün Başarıyla Oluşturuldu.");


            #endregion

            #region Ürün Listeleme İşlemi

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-51TNQ4H;initial catalog = EgitimKampiDb; integrated security = true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("select * from TblProduct", connection);
            //SqlDataAdapter adapter = new SqlDataAdapter();
            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);
            //foreach(DataRow row in dataTable.Rows)
            //{
            //    foreach(var item in row.ItemArray )
            //    {
            //        Console.WriteLine(item.ToString() + " ");
            //    }
            //    Console.WriteLine();
            //}

            //connection.Close();
            #endregion

            #region Ürün Silme İşlemleri

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-51TNQ4H;initial catalog = EgitimKampiDb; integrated security = true");
            //connection.Open();

            //Console.WriteLine("Silmek istediğiniz ürün Id= ");
            //int productId = int.Parse(Console.ReadLine());


            //SqlCommand command = new SqlCommand("DELETE from TblProduct where ProductId=@productId", connection);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery();

            //connection.Close();
            //Console.WriteLine("Silme İşlemi yapıldı.");
            #endregion

            #region Ürün Güncelleme İşlemi

            //Console.WriteLine("Güncellenecek Ürün Id = ");
            //int productId = int.Parse(Console.ReadLine());

            //Console.WriteLine("Güncellenecek Ürün Adı");
            //string productName = Console.ReadLine();


            //Console.WriteLine("Güncellenecek Ürün Fiyatı");
            //decimal productPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-51TNQ4H;initial catalog = EgitimKampiDb; integrated security = true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("Update TblProduct set ProductPrice = @productPrice, ProductName=@productName where ProductID = @productId", connection);
            //command.Parameters.AddWithValue("@productPrice",productPrice);
            //command.Parameters.AddWithValue("@productName",productName);
            //command.Parameters.AddWithValue("@productId",productId);
            //command.ExecuteNonQuery();

            //connection.Close();

            //Console.WriteLine("Ürün Başarıyla Güncellendi...");
            #endregion


            Console.ReadLine();
        }
    }
}
