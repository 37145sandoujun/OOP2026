using Microsoft.Data.Sqlite;

namespace SQLiteProductSample;



//Productsテーブルに対するDB操作をまとめたクラス
//CRUD（
public class ProductRepository
{
    public List<Product> GetAll()
    {

        var products = new List<Product>();

        using var connection = Database.GetConenection();
      
        connection.Open();

        //SQLを実行するためのコマンドオブジェクトを作る
        using var command = connection.CreateCommand();


        //ProdactsテーブルをつくるSQL
        //IF NOT EXISTS により、すでにテーブルがあってもエラーにならない
        command.CommandText =
            """
            SELECT Id, Name,Price
            FROM Products
            ORDER BY Id;


            """;

        //SELECTを実行し、複数行の検索結果を読み取る
       using var reader = command.ExecuteReader();

        while (reader.Read())
        {
            products.Add(new Product
            {
                id = reader.GetInt32(0),//0列目：Id
                Name = reader.GetString(1),//1列目：Name
                Price = reader.GetInt32(2)//２列目：Price
            });

        }
        return products;
    }
}
