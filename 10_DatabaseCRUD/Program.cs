using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCRUD
{
	internal class Program
	{
		static void Main(string[] args)
		{
            Console.WriteLine("***** Menü Sipariş İşlem Paneli *****");
            Console.WriteLine();

            Console.WriteLine("----------------------------------------");

			#region Kategori Ekleme İşlemi
			//         Console.Write("Eklemek istediğiniz kategori adı: ");
			//string categoryName = Console.ReadLine();

			//SqlConnection connection = new SqlConnection("Data Source=DESKTOP-KVMG1LU;" +
			//	"initial Catalog=egitim_kampi_DB;integrated security=true");
			//connection.Open();

			//SqlCommand command = new SqlCommand("insert into CategoryTable (CategoryName) values (@p1)" , connection);

			//command.Parameters.AddWithValue("@p1", categoryName);
			//command.ExecuteNonQuery();

			//connection.Close();

			//         Console.WriteLine("Kategori başarıyla eklendi!");
			#endregion

			#region Ürün Ekleme Ekranı
			//string productName;
			//decimal productPrice;
			////bool productStatus;

			//         Console.Write("Ürün adı : ");
			//         productName = Console.ReadLine();

			//Console.Write("Ürün fiyatı : ");
			//productPrice = decimal.Parse(Console.ReadLine());

			//SqlConnection connection = new SqlConnection("Data Source=DESKTOP-KVMG1LU;" +
			//	"initial Catalog=egitim_kampi_DB;integrated security=true");
			//connection.Open();

			//SqlCommand command = new SqlCommand("insert into ProductTable " +
			//	"(ProductName,ProductPrice,ProductStatus) " +
			//	"values(@productName,@productPrice,@productStatus)", connection);

			//command.Parameters.AddWithValue("@productName", productName);
			//command.Parameters.AddWithValue("@productPrice", productPrice);
			//command.Parameters.AddWithValue("@productStatus", true);
			//command.ExecuteNonQuery();

			//connection.Close();

			//         Console.WriteLine("Ekleme işlemi başarılı!");

			//Console.Read();

			#endregion

			#region Ürün Listeme İşlemi

			//SqlConnection connection = new SqlConnection("Data Source=DESKTOP-KVMG1LU;" +
			//	"initial Catalog=egitim_kampi_DB;integrated security=true");
			//connection.Open();

			//SqlCommand command = new SqlCommand("select * from ProductTable",connection);

			//SqlDataAdapter adapter = new SqlDataAdapter(command);

			//DataTable dataTable = new DataTable();

			//adapter.Fill(dataTable);

			//foreach (DataRow row in dataTable.Rows)
			//{
			//	foreach (var item in row.ItemArray)
			//	{
			//		//Console.Write(item.ToString() + "\t | ");
			//		Console.Write(item.ToString().PadRight(20) + "| ");
			//	}
			//             Console.WriteLine();
			//}

			//connection.Close();

			//Console.Read();

			#endregion

			#region Kategori Listeleme İşlemi

			//SqlConnection connection = new SqlConnection("Data Source=DESKTOP-KVMG1LU;" +
			//	"initial Catalog=egitim_kampi_DB;integrated security=true");
			//connection.Open();

			//SqlCommand command = new SqlCommand("select * from CategoryTable", connection);

			//SqlDataAdapter adapter = new SqlDataAdapter(command);

			//DataTable dataTable = new DataTable();

			//adapter.Fill(dataTable);

			//foreach (DataRow row in dataTable.Rows) 
			//{
			//	foreach(var item in row.ItemArray)
			//	{
			//		Console.Write(item.ToString().PadRight(20) + "| ");
			//	}
			//             Console.WriteLine();
			//}

			//connection.Close();

			//Console.Read();

			#endregion

			#region Ürün Silme İşlemi

			//string productName;
			//int productId;

			//Console.Write("Silmek istediğiniz ürünün adı : ");
			//productName = Console.ReadLine();

			//Console.Write("Silmek istediğiniz ürün Id : ");
			//productId = int.Parse(Console.ReadLine());

			//SqlConnection connection = new SqlConnection("Data Source=DESKTOP-KVMG1LU;" +
			//	"initial Catalog=egitim_kampi_DB;integrated security=true");
			//connection.Open();

			//SqlCommand command = new SqlCommand("delete from ProductTable where ProductId=@productId",connection);
			//command.Parameters.AddWithValue("@productId", productId);
			//command.ExecuteNonQuery();

			//SqlCommand command = new SqlCommand("delete from ProductTable where ProductName=@productName", connection);
			//command.Parameters.AddWithValue("@productName", productName);
			//command.ExecuteNonQuery();

			//connection.Close();

			//Console.WriteLine("Silme işlemi başarılı!");

			//Console.Read();
			#endregion

			#region Ürün Güncelleme İşlemi
			//int productId;
			//string productName;
			//decimal productPrice;

			//Console.Write("Güncellemek istediğiniz ürünün Id : ");
			//productId = int.Parse(Console.ReadLine());

			//Console.Write("Güncellemek istediğiniz ürünün adı : ");
			//productName = Console.ReadLine();

			//Console.Write("Güncellemek istediğiniz ürünün fiyatı : ");
			//productPrice = decimal.Parse(Console.ReadLine());

			//SqlConnection connection = new SqlConnection("Data Source=DESKTOP-KVMG1LU;" +
			//	"initial Catalog=egitim_kampi_DB;integrated security=true");
			//connection.Open();

			//SqlCommand command = new SqlCommand("Update ProductTable " +
			//	"set ProductName=@productName , ProductPrice=@productPrice " +
			//	"where ProductId=@productId",connection);

			//command.Parameters.AddWithValue("@productName", productName);
			//command.Parameters.AddWithValue("@productPrice", productPrice);
			//command.Parameters.AddWithValue("@productId", productId);

			//command.ExecuteNonQuery();

			//Console.WriteLine("Güncelleme başarılı!");

			//Console.Read();
			#endregion









		}
	}
}
