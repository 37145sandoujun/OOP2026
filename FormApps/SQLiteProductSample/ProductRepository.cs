using Microsoft.Data.Sqlite;
using System.Diagnostics;
using System.Xml.Linq;

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
                Id = reader.GetInt32(0),//0列目：Id
                Name = reader.GetString(1),//1列目：Name
                Price = reader.GetInt32(2)//２列目：Price
            });

        }
        return products;
    }

 public int Add(string name, int price)
    {
        using var connection = Database.GetConenection();

        connection.Open();

        //SQLを実行するためのコマンドオブジェクトを作る
        using var command = connection.CreateCommand();


      
        command.CommandText =
            """
            INSERT INTO Products(Name,Price)
            VALUES ($name,$price);

            SELECT last_insert_rowid();
            """;

        command.Parameters.AddWithValue("$name", name);
        command.Parameters.AddWithValue("$price", price);

       
      var reselt =  command.ExecuteScalar();


        if (reselt is null)
            throw new InvalidOperationException("登録した商品のIDを取得できませんでした");

        //SQLiteのINTEGERはlongとして帰るため、intへ変換する
        return Convert.ToInt32((long)reselt);
    }
    public void Update(Product product)
    {
        using var connection = Database.GetConenection();

        connection.Open();

        //SQLを実行するためのコマンドオブジェクトを作る
        using var command = connection.CreateCommand();


       
        command.CommandText =
            """
            UPDATE Products
            SET Name = $name,
                Price = $price
            WHERE Id = $id;
            """;

        command.Parameters.AddWithValue("$name",product.Name);
        command.Parameters.AddWithValue("$price", product.Price);
        command.Parameters.AddWithValue("$id", product.Id);

        var reselt = command.ExecuteScalar();

        //更新件数が０なら対象が存在しない
        if (reselt is null)
            throw new InvalidOperationException("修正対象の商品が見つかりませんでした");

        
    }
}
