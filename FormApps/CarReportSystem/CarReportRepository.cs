using CarReportSystem;
using Microsoft.Data.Sqlite;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.Globalization;
using System.Xml.Linq;

namespace SQLiteProductSample;



//Productsテーブルに対するDB操作をまとめたクラス
//CRUD（
public class CarReportRepository
{
    public List<CarReport> GetAll()
    {

        var carReports = new List<CarReport>();

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
            carReports.Add(new CarReport
            {
                Id = reader.GetInt32(0),//0列目：Id
                Date = DateTime.ParseExact(
                   reader.GetString(1),
                   "yyyy-MM-dd",
                   CultureInfo.InvariantCulture),

                Author = reader.GetString(2),
                Maker = (CarReport.MakerGroup)reader.GetInt32(0),
                CarName = reader.GetString(4),
                Report = reader.GetString(5),
              //  Picture = Image.
            });


        }
        return carReports;
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
        command.ExecuteNonQuery();

        var reselt = command.ExecuteScalar();

        //更新件数が０なら対象が存在しない
        if (reselt is not  null)
            throw new InvalidOperationException("修正対象の商品が見つかりませんでした");

        
    }

    public void Delete(int id)
    {
        using var connection = Database.GetConenection();
        connection.Open();

        using var command = connection.CreateCommand();
        command.CommandText =
            """
            DELETE FROM Products
            WHERE Id = $id;

            """;

        command.Parameters.AddWithValue("$id", id);
        command.ExecuteNonQuery();
    }

    // ImageをSQLiteへ保存できるbyte[]へ変換する
    private static byte[]? ImageToBytes(Image? image)
    {
        if (image is null) return null;

        using var stream = new MemoryStream();
        // DBへはPNG形式で保存
        image.Save(stream, ImageFormat.Png);
        return stream.ToArray();
    }

    // SQLiteのBLOB（byte[]）をImageへ変換する
    private static Image BytesToImage(byte[] data)
    {
        using var stream = new MemoryStream(data);
        using var image = Image.FromStream(stream);
        // MemoryStream破棄後も利用できるようBitmapとしてコピーする。
        return new Bitmap(image);
    }
}
