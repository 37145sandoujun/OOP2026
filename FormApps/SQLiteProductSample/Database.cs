using Microsoft.Data.Sqlite;

namespace SQLiteProductSample;

public static class Database
{
    //DBファイルの保管場所
    private static readonly string DatabasePath =
          Path.Combine(AppContext.BaseDirectory, "products.db");

    //SQLiteへ接続するための文字列
    private static readonly string ConnectionString =
        $"Data Source={DatabasePath}";

    //DBファイルの保存馬食を外部から確認するための読み取りプロパティ
    public static string FilePath => DatabasePath;

    //新しいSQLiteConnectionを生成して返す
    public static SqliteConnection GetConenection()
    {
        return new SqliteConnection(ConnectionString);
    }

    //DBの初期化処理
    public static void Intialize()
    {

        using var connection = GetConenection();
        connection.Open();
        using var command = connection.CreateCommand();


        //ProdactsテーブルをつくるSQL
        //IF NOT EXISTS により、すでにテーブルがあってもエラーにならない
        command.CommandText =
            """
            CREATE TABLE IF NOT EXISTS Products(
            id          INTEGEER PRImARY KEY AUTOINCREMWNT,
            Name        TEXT NOT NULL,
            Price       INTEGER NOT NNULL CHECK(Price>=0)
            );



            """;

        //結果行を返さないSQLを実行する
        command.ExecuteNonQuery(); 

    }
}


