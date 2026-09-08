using CarReportSystem;
using Microsoft.Data.Sqlite;
using System.Diagnostics;
using System.Diagnostics.Metrics;
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
        //全レポートを取得する
        var carReports = new List<CarReport>();

        using var connection = Database.GetConenection();
      
        connection.Open();

        //SQLを実行するためのコマンドオブジェクトを作る
        using var command = connection.CreateCommand();


        //ProdactsテーブルをつくるSQL
        //IF NOT EXISTS により、すでにテーブルがあってもエラーにならない
        command.CommandText =
            """
            SELECT Id, Date, Author, Maker, CarName, Report, Picture
            FROM CarReports
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
               Picture = reader.IsDBNull(6)
                    ?null:BytesToImage(reader.GetFieldValue<byte[]>(6))
            });


        }
        return carReports;
    }

 public int Add(int date ,int author ,int maker ,string carName, int report, Image picture)
    {
        using var connection = Database.GetConenection();

        connection.Open();

        //SQLを実行するためのコマンドオブジェクトを作る
        using var command = connection.CreateCommand();


      
        command.CommandText =
            """
            INSERT INTO CarReports(Date,Author, Maker, CarName, Report, Picture)
            VALUES ($date,$author, $maker,$carName,$report,$picture);

            SELECT last_insert_rowid();
            """;

        command.Parameters.AddWithValue("$date",date);
        command.Parameters.AddWithValue("$author", author);
        command.Parameters.AddWithValue("$maker", maker);
        command.Parameters.AddWithValue("$carName", carName);
        command.Parameters.AddWithValue("$report", report);
        command.Parameters.AddWithValue("$picture", picture);


        var reselt =  command.ExecuteScalar();


        if (reselt is null)
            throw new InvalidOperationException("登録した商品のIDを取得できませんでした");

        //SQLiteのINTEGERはlongとして帰るため、intへ変換する
        return Convert.ToInt32((long)reselt);
    }
    public void Update(CarReport carReport)
    {
        using var connection = Database.GetConenection();

        connection.Open();

        //SQLを実行するためのコマンドオブジェクトを作る
        using var command = connection.CreateCommand();


       
        command.CommandText =
            """
            UPDATE CarReports
            SET Date = $date, Author = $author, Maker = 
            $maker, CarName = $carname, Report = $report, Picture = $picture
            WHERE Id = $id;
            """;

        command.Parameters.AddWithValue("$date",carReport.Date);
        command.Parameters.AddWithValue("$autohr", carReport.Author);
        command.Parameters.AddWithValue("$maker", carReport.Maker);
        command.Parameters.AddWithValue("$carname", carReport.CarName);
        command.Parameters.AddWithValue("$report", carReport.Report);
        command.Parameters.AddWithValue("$picture", carReport.Picture);
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
            DELETE FROM CarReports
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
